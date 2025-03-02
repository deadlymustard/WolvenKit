using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;


namespace WolvenKit.RED4.Archive.IO
{
    public partial class PackageWriter : Red4Writer
    {

        public PackageWriter(Stream output) : base(output)
        {
        }

        public PackageWriter(Stream output, Encoding encoding) : base(output, encoding)
        {
        }

        public PackageWriter(Stream output, Encoding encoding, bool leaveOpen) : base(output, encoding, leaveOpen)
        {
        }

        public override void Write(CRUID val) => _writer.Write(val);

        private readonly List<Type> _ignoreCRUIDS = new()
        {
            typeof(entEffectDesc),
            typeof(worldCompiledEffectEventInfo)
        };

        private readonly List<Type> _doubleHeaderCRUIDS = new()
        {
            typeof(entExternalComponent),
            typeof(entMeshComponent),
            typeof(entSkinnedMeshComponent)
        };

        public override void WriteClass(RedBaseClass cls)
        {
            var typeInfo = RedReflection.GetTypeInfo(cls.GetType());


            var nonDefaultProperties = new List<RedReflection.ExtendedPropertyInfo>();

            if (PackageWriter.IsDebug)
            {
                var tmp = cls.GetWrittenPropertyNames();
                var tmp2 = new RedReflection.ExtendedPropertyInfo[tmp.Count];
                foreach (var propertyInfo in typeInfo.PropertyInfos)
                {
                    var value = propertyInfo.GetValue(cls);
                    if (propertyInfo.Type == typeof(CRUID) && _doubleHeaderCRUIDS.Contains(cls.GetType()))
                    {
                        _cruids.Add((CRUID)value);
                    }

                    var index = tmp.IndexOf(propertyInfo.RedName);
                    if (index != -1)
                    {
                        tmp2[index] = propertyInfo;
                    }
                }

                nonDefaultProperties = tmp2.ToList();
            }
            else
            {
                foreach (var propertyInfo in typeInfo.PropertyInfos)
                {
                    var value = propertyInfo.GetValue(cls);
                    if (!typeInfo.SerializeDefault && !propertyInfo.SerializeDefault && RedReflection.IsDefault(cls.GetType(), propertyInfo, value))
                    {
                        if (propertyInfo.Type == typeof(CRUID) && _doubleHeaderCRUIDS.Contains(cls.GetType()))
                        {
                            _cruids.Add((CRUID)value);
                        }

                        continue;
                    }
                    nonDefaultProperties.Add(propertyInfo);
                }
            }


            _writer.Write((ushort)nonDefaultProperties.Count);
            var currentDataPosition = BaseStream.Position + nonDefaultProperties.Count * 8;
            var descStartPosition = BaseStream.Position;

            foreach (var propertyInfo in nonDefaultProperties)
            {
                var value = propertyInfo.GetValue(cls);
                var redTypeName = RedReflection.GetRedTypeFromCSType(propertyInfo.Type, propertyInfo.Flags.Clone());

                BaseStream.Position = descStartPosition + nonDefaultProperties.IndexOf(propertyInfo) * 8;

                CNameRef.Add(_writer.BaseStream.Position, propertyInfo.RedName);
                _writer.Write(GetStringIndex(propertyInfo.RedName));

                CNameRef.Add(_writer.BaseStream.Position, redTypeName);
                _writer.Write(GetStringIndex(redTypeName));

                _writer.Write((uint)(currentDataPosition - descStartPosition + 2));

                BaseStream.Position = currentDataPosition;
                // write data, prefixed with size?
                Write((IRedType)value);

                if (propertyInfo.Type == typeof(CRUID) && !_ignoreCRUIDS.Contains(cls.GetType()))
                {
                    _cruids.Add((CRUID)value);
                }

                currentDataPosition = BaseStream.Position;
            }

            if (cls is IRedAppendix app)
            {
                app.Write(this);
            }
        }

        public override void Write(IRedBitField instance)
        {
            var enumString = instance.ToBitFieldString();
            if (enumString == "0")
            {
                _writer.Write((byte)0);
                return;
            }

            var flags = enumString.Split(',');

            _writer.Write((byte)flags.Length);
            for (var i = 0; i < flags.Length; i++)
            {
                var tFlag = flags[i].Trim();
                CNameRef.Add(_writer.BaseStream.Position, tFlag);
                _writer.Write(GetStringIndex(tFlag));
            }
        }

        public override void Write(IRedHandle instance)
        {
            var target = instance.GetValue();

            if (_header.version == 2)
            {
                if (target != null)
                {
                    InternalHandleWriter(target, 0, typeof(short));
                }
                else
                {
                    BaseWriter.Write((short)-1);
                }
            }
            else if (_header.version == 03 || _header.version == 04)
            {
                if (target != null)
                {
                    InternalHandleWriter(target, 0);
                }
                else
                {
                    BaseWriter.Write(-1);
                }
            }
            else
            {
                throw new NotSupportedException(nameof(Write));
            }
        }

        public override void Write(IRedWeakHandle instance)
        {
            if (_header.version == 2)
            {
                InternalHandleWriter(instance.GetValue(), 0, typeof(short));
            }
            else if (_header.version == 03 || _header.version == 04)
            {
                InternalHandleWriter(instance.GetValue(), 0);
            }
            else
            {
                throw new NotSupportedException(nameof(Write));
            }
        }

        public override void Write(IRedResourceReference instance)
        {
            // TODO: Find a better way (written as -1)
            if (instance.DepotPath == "INVALID")
            {
                _writer.Write((short)-1);
                return;
            }

            var val = ("", instance.DepotPath, (ushort)instance.Flags);

            ImportRef.Add(_writer.BaseStream.Position, val);
            _writer.Write(GetImportIndex(val));
        }

        public override void Write(IRedResourceAsyncReference instance)
        {
            // TODO: Find a better way (written as -1)
            if (instance.DepotPath == "INVALID")
            {
                _writer.Write((short)-1);
                return;
            }

            var val = ("", instance.DepotPath, (ushort)instance.Flags);

            ImportRef.Add(_writer.BaseStream.Position, val);
            _writer.Write(GetImportIndex(val));
        }

        public override void Write(NodeRef val)
        {
            var strBytes = Encoding.UTF8.GetBytes(val);

            _writer.Write((short)strBytes.Length);
            _writer.Write(strBytes);
        }

        public override void Write(LocalizationString val)
        {
            var strBytes = Encoding.UTF8.GetBytes(val.Value);

            _writer.Write(val.Unk1);
            _writer.Write((short)strBytes.Length);
            _writer.Write(strBytes);
        }

        public override void Write(CString val)
        {
            var strBytes = Encoding.UTF8.GetBytes(val);

            _writer.Write((short)strBytes.Length);
            _writer.Write(strBytes);
        }

        public override void Write(DataBuffer val)
        {
            if (val.Buffer.IsEmpty)
            {
                _writer.Write(0x80000000);
            }
            else
            {
                _writer.Write(val.Buffer.MemSize);
                _writer.Write(val.Buffer.GetBytes());
            }
        }

        public override void Write(TweakDBID val)
        {
            if (_header.version == 02 || _header.version == 03)
            {
                _writer.Write((short)val.Length);
                _writer.Write(Encoding.UTF8.GetBytes(val));
            }
            else if (_header.version == 04)
            {
                base.Write(val);
            }
            else
            {
                throw new NotSupportedException(nameof(Write));
            }
        }
    }
}
