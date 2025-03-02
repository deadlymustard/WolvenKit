using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Crosshair_Smart_Rifl_Bucket : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("progressBarValue")] 
		public inkWidgetReference ProgressBarValue
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("targetIndicator")] 
		public inkWidgetReference TargetIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("lockedIndicator")] 
		public inkWidgetReference LockedIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("lockingIndicator")] 
		public inkWidgetReference LockingIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public gamesmartGunUITargetParameters Data
		{
			get => GetPropertyValue<gamesmartGunUITargetParameters>();
			set => SetPropertyValue<gamesmartGunUITargetParameters>(value);
		}

		[Ordinal(7)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public Crosshair_Smart_Rifl_Bucket()
		{
			ProgressBar = new();
			ProgressBarValue = new();
			TargetIndicator = new();
			LockedIndicator = new();
			LockingIndicator = new();
			Data = new() { Pos = new(), EntityID = new() };
		}
	}
}
