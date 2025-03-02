using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpGameplayLightComponent : entLightComponent
	{
		[Ordinal(54)] 
		[RED("reactToTime")] 
		public CBool ReactToTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("begin")] 
		public GameTime Begin
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(56)] 
		[RED("end")] 
		public GameTime End
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(57)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("delayRange")] 
		public GameTime DelayRange
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		public cpGameplayLightComponent()
		{
			Begin = new();
			End = new();
			DelayRange = new();
		}
	}
}
