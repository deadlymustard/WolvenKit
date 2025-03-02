using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinimalItemTooltipDataRequirements : IScriptable
	{
		[Ordinal(0)] 
		[RED("isLevelRequirementNotMet")] 
		public CBool IsLevelRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isSmartlinkRequirementNotMet")] 
		public CBool IsSmartlinkRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isStrengthRequirementNotMet")] 
		public CBool IsStrengthRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isReflexRequirementNotMet")] 
		public CBool IsReflexRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isAnyStatRequirementNotMet")] 
		public CBool IsAnyStatRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("strengthOrReflexStatName")] 
		public CString StrengthOrReflexStatName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("anyStatName")] 
		public CString AnyStatName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("anyStatColor")] 
		public CString AnyStatColor
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("anyStatLocKey")] 
		public CString AnyStatLocKey
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("strengthOrReflexValue")] 
		public CInt32 StrengthOrReflexValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("anyStatValue")] 
		public CInt32 AnyStatValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("requiredLevel")] 
		public CInt32 RequiredLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
