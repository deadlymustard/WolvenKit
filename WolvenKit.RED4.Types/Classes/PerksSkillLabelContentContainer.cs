using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerksSkillLabelContentContainer : HubMenuLabelContentContainer
	{
		[Ordinal(8)] 
		[RED("levelLabel")] 
		public inkTextWidgetReference LevelLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("levelBar")] 
		public inkWidgetReference LevelBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("skillData")] 
		public CHandle<ProficiencyDisplayData> SkillData
		{
			get => GetPropertyValue<CHandle<ProficiencyDisplayData>>();
			set => SetPropertyValue<CHandle<ProficiencyDisplayData>>(value);
		}

		public PerksSkillLabelContentContainer()
		{
			LevelLabel = new();
			LevelBar = new();
		}
	}
}
