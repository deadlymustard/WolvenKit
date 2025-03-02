using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPuppetAIManagerNodeDefinitionEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("aiTier")] 
		public CEnum<gameStoryTier> AiTier
		{
			get => GetPropertyValue<CEnum<gameStoryTier>>();
			set => SetPropertyValue<CEnum<gameStoryTier>>(value);
		}

		public questPuppetAIManagerNodeDefinitionEntry()
		{
			EntityReference = new() { Names = new() };
		}
	}
}
