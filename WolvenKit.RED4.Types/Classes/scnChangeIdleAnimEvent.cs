using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnChangeIdleAnimEvent : scnPlayAnimEvent
	{
		[Ordinal(15)] 
		[RED("idleAnimName")] 
		public CName IdleAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("addIdleAnimName")] 
		public CName AddIdleAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("bakedFacialTransition")] 
		public animFacialEmotionTransitionBaked BakedFacialTransition
		{
			get => GetPropertyValue<animFacialEmotionTransitionBaked>();
			set => SetPropertyValue<animFacialEmotionTransitionBaked>(value);
		}

		[Ordinal(20)] 
		[RED("facialInstantTransition")] 
		public CBool FacialInstantTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnChangeIdleAnimEvent()
		{
			Id = new() { Id = 18446744073709551615 };
			Duration = 1000;
			AnimData = new() { Basic = new() { Stretch = 1.000000F, BlendInCurve = Enums.scnEasingType.SinusoidalEaseInOut, BlendOutCurve = Enums.scnEasingType.SinusoidalEaseInOut }, Weight = 1.000000F };
			Performer = new() { Id = 4294967040 };
			NeckWeight = 1.000000F;
			UpperFaceBlendAdditive = true;
			LowerFaceBlendAdditive = true;
			EyesBlendAdditive = true;
			IsEnabled = true;
			BakedFacialTransition = new() { TransitionType = Enums.animFacialEmotionTransitionType.Fast, ToIdleWeight = 1.000000F };
		}
	}
}
