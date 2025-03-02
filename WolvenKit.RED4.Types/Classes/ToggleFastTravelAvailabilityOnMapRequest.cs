using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleFastTravelAvailabilityOnMapRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("pointRecord")] 
		public TweakDBID PointRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
