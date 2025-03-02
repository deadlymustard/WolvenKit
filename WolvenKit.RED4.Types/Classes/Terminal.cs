using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Terminal : InteractiveMasterDevice
	{
		[Ordinal(97)] 
		[RED("cameraFeed")] 
		public CHandle<ScriptableVirtualCameraViewComponent> CameraFeed
		{
			get => GetPropertyValue<CHandle<ScriptableVirtualCameraViewComponent>>();
			set => SetPropertyValue<CHandle<ScriptableVirtualCameraViewComponent>>(value);
		}

		[Ordinal(98)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(99)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public Terminal()
		{
			ControllerTypeName = "TerminalController";
			ShortGlitchDelayID = new();
		}
	}
}
