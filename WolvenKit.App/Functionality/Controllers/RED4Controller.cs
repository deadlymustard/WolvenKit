using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core;
using WolvenKit.Core.Compression;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Modkit.RED4.Serialization;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.RED4.TweakDB;

namespace WolvenKit.Functionality.Controllers
{
    public class RED4Controller : ReactiveObject, IGameController
    {
        #region fields

        public const string GameVersion = "1.3.0";

        private readonly ILoggerService _loggerService;
        private readonly INotificationService _notificationService;
        private readonly IProjectManager _projectManager;
        private readonly ISettingsManager _settingsManager;
        private readonly IHashService _hashService;
        private readonly IModTools _modTools;
        private readonly IArchiveManager _archiveManager;
        private bool _initialized = false;

        #endregion

        public RED4Controller(
            ILoggerService loggerService,
            INotificationService notificationService,
            IProjectManager projectManager,
            ISettingsManager settingsManager,
            IHashService hashService,
            IModTools modTools,
            IArchiveManager gameArchiveManager
            )
        {
            _notificationService = notificationService;
            _loggerService = loggerService;
            _projectManager = projectManager;
            _settingsManager = settingsManager;
            _hashService = hashService;
            _modTools = modTools;
            _archiveManager = gameArchiveManager;

        }

        #region Methods

        public Task HandleStartup()
        {
            if (!_initialized)
            {
                _initialized = true;

                // load archives
                var todo = new List<Func<IArchiveManager>>()
                {
                    LoadArchiveManager,
                };
                Parallel.ForEach(todo, _ => Task.Run(_));

                // requires oodle
                InitializeBk();
                InitializeRedDB();
            }

            return Task.CompletedTask;
        }

        private void InitializeBk()
        {
            string[] binkhelpers = { @"Resources\Media\t1.kark", @"Resources\Media\t2.kark", @"Resources\Media\t3.kark", @"Resources\Media\t4.kark", @"Resources\Media\t5.kark" };

            if (string.IsNullOrEmpty(_settingsManager.GetRED4GameRootDir()))
            {
                Trace.WriteLine("That worked to cancel Loading oodle! :D");
                return;
            }

            foreach (var path in binkhelpers)
            {
                switch (path)
                {
                    case @"Resources\Media\t1.kark":
                        if (!File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "test.exe")))
                        {
                            _ = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "test.exe"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t2.kark":
                        if (!File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe")))
                        {
                            _ = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "testconv.exe"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t3.kark":
                        if (!File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe")))
                        {
                            _ = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "testc.exe"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t4.kark":
                        if (!File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "radutil.dll")))
                        {
                            _ = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "radutil.dll"), true,
                                false);
                        }

                        break;

                    case @"Resources\Media\t5.kark":
                        if (!File.Exists(Path.Combine(ISettingsManager.GetWorkDir(), "bink2make.dll")))
                        {
                            _ = OodleTask(path, Path.Combine(ISettingsManager.GetWorkDir(), "bink2make.dll"), true,
                                false);
                        }

                        break;
                }
            }
        }

        private void InitializeRedDB()
        {
            var resourcePath = Path.GetFullPath(Path.Combine("Resources", "red.kark"));
            var destinationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "red.db");

            var (hash, size) = CommonFunctions.HashFileSHA512(resourcePath);

            if (!File.Exists(destinationPath))
            {
                OodleTask(resourcePath, destinationPath, true, false);
                _settingsManager.ReddbHash = hash;
                _settingsManager.Save();
            }
            else
            {
                if (!hash.Equals(_settingsManager.ReddbHash))
                {
                    _loggerService.Info($"old hash: {_settingsManager.ReddbHash}, new hash: {hash}. Updating reddb");
                    OodleTask(resourcePath, destinationPath, true, false);
                    _settingsManager.ReddbHash = hash;
                    _settingsManager.Save();
                }
            }
        }

        private static int OodleTask(string path, string outpath, bool decompress, bool compress)
        {
            if (string.IsNullOrEmpty(path))
            {
                return 0;
            }

            if (string.IsNullOrEmpty(outpath))
            {
                outpath = Path.ChangeExtension(path, ".kark");
            }

            if (decompress)
            {
                var file = File.ReadAllBytes(path);
                using var ms = new MemoryStream(file);
                using var br = new BinaryReader(ms);

                var oodleCompression = br.ReadBytes(4);
                if (!(oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b })))
                {
                    throw new NotImplementedException();
                }

                var size = br.ReadUInt32();

                var buffer = br.ReadBytes(file.Length - 8);

                var unpacked = new byte[size];
                var unpackedSize = Oodle.Decompress(buffer, unpacked);

                using var msout = new MemoryStream();
                using var bw = new BinaryWriter(msout);
                bw.Write(unpacked);

                File.WriteAllBytes($"{outpath}", msout.ToArray());
            }

            if (compress)
            {
                var inbuffer = File.ReadAllBytes(path);
                IEnumerable<byte> outBuffer = new List<byte>();

                var r = Oodle.Compress(inbuffer, ref outBuffer, true);

                File.WriteAllBytes(outpath, outBuffer.ToArray());
            }

            return 1;
        }

        private IArchiveManager LoadArchiveManager()
        {
            if (_archiveManager != null && _archiveManager.IsManagerLoaded)
            {
                return _archiveManager;
            }

            _loggerService.Info("Loading Archive Manager ... ");
            //var chachePath = Path.Combine(ISettingsManager.GetAppData(), "archive_cache.bin");
            try
            {
                //if (File.Exists(chachePath))
                //{
                //    var sw = new Stopwatch();
                //    sw.Start();

                //    using var file = File.OpenRead(chachePath);
                //    ArchiveManager = Serializer.Deserialize<ArchiveManager>(file);

                //    sw.Stop();
                //    var ms = sw.ElapsedMilliseconds;

                //    if (!ArchiveManager.GameVersion.Equals(GameVersion))
                //    {
                //        throw new NotSupportedException(ArchiveManager.GameVersion.ToString());
                //    }
                //}
                //else
                {
                    var sw = new Stopwatch();
                    sw.Start();

                    _archiveManager.LoadGameArchives(new FileInfo(_settingsManager.CP77ExecutablePath));

                    sw.Stop();
                    var ms = sw.ElapsedMilliseconds;

                    //using var file = File.Create(chachePath);
                    //Serializer.Serialize(file, ArchiveManager);

                    //_settingsManager.ManagerVersions[(int)EManagerType.ArchiveManager] =
                    //    ArchiveManager.SerializationVersion;
                }
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
                throw;


                //ArchiveManager = new ArchiveManager(_hashService) /*{ GameVersion = GameVersion }*/;
                //ArchiveManager.LoadAll(new FileInfo(_settingsManager.CP77ExecutablePath));

                //using var file = File.Create(chachePath);
                //Serializer.Serialize(file, ArchiveManager);

                //_settingsManager.ManagerVersions[(int)EManagerType.ArchiveManager] =
                //    ArchiveManager.SerializationVersion;
            }
            finally
            {
                _loggerService.Success("Finished loading Archive Manager.");
            }

#pragma warning disable 162
            return _archiveManager;
#pragma warning restore 162
        }

        //public List<string> GetAvaliableClasses() => CR2WTypeManager.AvailableTypes.ToList();

        public Task<bool> PackageMod()
        {

            if (_projectManager.ActiveProject is not Cp77Project cp77Proj)
            {
                _loggerService.Error("Can't pack project (no project/not cyberpunk project)!");
                return Task.FromResult(false);
            }

            try
            {
                var archives = Directory.GetFiles(cp77Proj.PackedModDirectory, "*.archive");
                foreach (var archive in archives)
                {
                    File.Delete(archive);
                }
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
            }

            // pack mod
            var modfiles = Directory.GetFiles(cp77Proj.ModDirectory, "*", SearchOption.AllDirectories);
            if (modfiles.Any())
            {
                _modTools.Pack(
                    new DirectoryInfo(cp77Proj.ModDirectory),
                    new DirectoryInfo(cp77Proj.PackedModDirectory),
                    cp77Proj.Name);
                _loggerService.Info("Packing archives complete!");
            }

            // compile tweak files
            CompileTweakFiles(cp77Proj);

            _loggerService.Success($"{cp77Proj.Name} packed into {cp77Proj.PackedModDirectory}!");

            return Task.FromResult(true);

            //var pwm = ServiceLocator.Default.ResolveType<Models.Wizards.PublishWizardModel>();
            //var headerBackground = System.Drawing.Color.FromArgb(
            //    pwm.HeaderBackground.A,
            //    pwm.HeaderBackground.R,
            //    pwm.HeaderBackground.G,
            //    pwm.HeaderBackground.B
            //);
            //var iconBackground = System.Drawing.Color.FromArgb(
            //    pwm.IconBackground.A,
            //    pwm.IconBackground.R,
            //    pwm.IconBackground.G,
            //    pwm.IconBackground.B
            //);
            //var author = Tuple.Create<string, string, string, string, string, string>(
            //    _projectManager.ActiveProject.Author, null, pwm.WebsiteLink, pwm.FacebookLink, pwm.TwitterLink, pwm.YoutubeLink
            //);
            //var package = Common.Model.Packaging.WKPackage.CreateModAssembly(
            //    _projectManager.ActiveProject.Version,
            //    _projectManager.ActiveProject.Name,
            //    author,
            //    pwm.Description,
            //    pwm.LargeDescription,
            //    pwm.License,
            //    (headerBackground, pwm.UseBlackText, iconBackground).ToTuple(),
            //    new List<System.Xml.Linq.XElement> { }
            //);

            //return Task.FromResult(true);
        }

        /// <summary>
        /// packs redengine files in the mod project and installs it into the game mod directory
        /// </summary>
        /// <returns></returns>
        public Task<bool> PackAndInstallProject()
        {
            var packTask = PackageMod();
            if (!packTask.Result)
            {
                return Task.FromResult(false);
            }

            InstallMod();

            return Task.FromResult(true);
        }

        private void CompileTweakFiles(Cp77Project cp77Proj)
        {
            try
            {
                Directory.Delete(cp77Proj.PackedTweakDirectory, true);
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
            }

            var tweakFiles = Directory.GetFiles(cp77Proj.TweakDirectory, "*.tweak", SearchOption.AllDirectories);
            foreach (var f in tweakFiles)
            {
                var text = File.ReadAllText(f);
                var folder = Path.GetDirectoryName(Path.GetRelativePath(cp77Proj.TweakDirectory, f));
                var outDirectory = Path.Combine(cp77Proj.PackedTweakDirectory, folder);
                if (!Directory.Exists(outDirectory))
                {
                    Directory.CreateDirectory(outDirectory);
                }
                var filename = Path.GetFileNameWithoutExtension(f) + ".bin";
                var outPath = Path.Combine(outDirectory, filename);

                try
                {
                    if (!Serialization.Deserialize(text, out var dict))
                    {
                        continue;
                    }
                    var db = new TweakDB();
                    //flats
                    foreach (var (key, value) in dict.Flats)
                    {
                        db.Add(key, value);
                    }
                    //groups
                    foreach (var (key, value) in dict.Groups)
                    {
                        db.Add(key, value);
                    }

                    db.Save(outPath);
                }
                catch (Exception e)
                {
                    _loggerService.Error(e);
                    continue;
                }
            }
        }

        /// <summary>
        /// Copies the contents of the "packed" folder into the game mod directory
        /// </summary>
        public void InstallMod()
        {
            var activeMod = _projectManager.ActiveProject;
            var logPath = Path.Combine(activeMod.ProjectDirectory, "install_log.xml");

            try
            {
                //Check if we have installed this mod before. If so do a little cleanup.
                if (File.Exists(logPath))
                {
                    var log = XDocument.Load(logPath);
                    var dirs = log.Root.Element("Files")?.Descendants("Directory").ToList();
                    if (dirs != null)
                    {
                        //Loop throught dirs and delete the old files in them.
                        foreach (var d in dirs)
                        {
                            foreach (var f in d.Elements("file"))
                            {
                                if (File.Exists(f.Value))
                                {
                                    File.Delete(f.Value);
                                    Debug.WriteLine("File delete: " + f.Value);
                                }
                            }
                        }
                        //Delete the empty directories.
                        foreach (var d in dirs)
                        {
                            if (d.Attribute("Path") != null
                                && Directory.Exists(d.Attribute("Path").Value)
                                && !Directory.GetFiles(d.Attribute("Path").Value, "*", SearchOption.AllDirectories).Any())
                            {
                                Directory.Delete(d.Attribute("Path").Value, true);
                                Debug.WriteLine("Directory delete: " + d.Attribute("Path").Value);
                            }
                        }
                    }
                    //Delete the old install log. We will make a new one so this is not needed anymore.
                    File.Delete(logPath);
                }

                var installlog = new XDocument(
                    new XElement("InstalLog",
                        new XAttribute("Project", activeMod.Name),
                        new XAttribute("Build_date", DateTime.Now.ToString())
                        ));
                var fileroot = new XElement("Files");

                //Copy and log the files.
                var packedmoddir = activeMod.PackedRootDirectory;
                if (!Directory.Exists(packedmoddir))
                {
                    _loggerService.Error("Failed to install the mod! The packed directory doesn't exist!");
                    return;
                }

                fileroot.Add(Commonfunctions.DirectoryCopy(packedmoddir, _settingsManager.GetRED4GameRootDir(), true));

                //var packeddlcdir = Path.Combine(ActiveMod.ProjectDirectory, "packed", "DLC");
                //if (Directory.Exists(packeddlcdir))
                //    fileroot.Add(Commonfunctions.DirectoryCopy(packeddlcdir, MainController.Get().Configuration.CP77GameDlcDir, true));

                installlog.Root.Add(fileroot);
                installlog.Save(logPath);
                _loggerService.Success($"{activeMod.Name} installed!");
                _notificationService.Success($"{activeMod.Name} installed!");
            }
            catch (Exception ex)
            {
                //If we screwed up something. Log it.
                _loggerService.Error(ex);
            }
        }

        public void AddToMod(ulong hash)
        {
            var file = _archiveManager.Lookup(hash);
            if (file.HasValue)
            {
                AddToMod(file.Value);
            }
        }

        private void AddToMod(IGameFile file)
        {
            var project = _projectManager.ActiveProject;
            switch (project.GameType)
            {
                case GameType.Witcher3:
                {
                    //if (project is Tw3Project witcherProject)
                    //{
                    //    var diskPathInfo = new FileInfo(Path.Combine(witcherProject.ModCookedDirectory, file.Name));
                    //    if (diskPathInfo.Directory == null)
                    //    {
                    //        break;
                    //    }

                    //    Directory.CreateDirectory(diskPathInfo.Directory.FullName);
                    //    using var fs = new FileStream(diskPathInfo.FullName, FileMode.Create);
                    //    file.Extract(fs);
                    //}
                    break;
                }
                case GameType.Cyberpunk2077:
                {
                    if (project is Cp77Project cyberpunkProject)
                    {
                        var diskPathInfo = new FileInfo(Path.Combine(cyberpunkProject.ModDirectory, file.Name));
                        if (diskPathInfo.Directory == null)
                        {
                            break;
                        }

                        if (File.Exists(diskPathInfo.FullName))
                        {
                            if (MessageBox.Show($"The file {file.Name} already exists in project - overwrite it with game file?", $"Confirm overwrite: {file.Name}", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                            {
                                using var fs = new FileStream(diskPathInfo.FullName, FileMode.Create);
                                file.Extract(fs);
                                _loggerService.Success($"Overwrote existing file with game file: {file.Name}");
                            }
                            else
                            {
                                _loggerService.Info($"Declined to overwrite existing file: {file.Name}");
                            }
                        }
                        else
                        {
                            Directory.CreateDirectory(diskPathInfo.Directory.FullName);
                            using var fs = new FileStream(diskPathInfo.FullName, FileMode.Create);
                            file.Extract(fs);
                            _loggerService.Success($"Added game file to project: {file.Name}");
                        }
                    }

                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion Methods
    }
}
