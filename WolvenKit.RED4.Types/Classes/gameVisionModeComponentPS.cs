using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisionModeComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("hideInDefaultMode")] 
		public CBool HideInDefaultMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("hideInFocusMode")] 
		public CBool HideInFocusMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("inactive")] 
		public CBool Inactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("questInactive")] 
		public CBool QuestInactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("questForcedModules")] 
		public CArray<CName> QuestForcedModules
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("questForcedMeshes")] 
		public CArray<CName> QuestForcedMeshes
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("storedHighlightData")] 
		public CHandle<FocusForcedHighlightPersistentData> StoredHighlightData
		{
			get => GetPropertyValue<CHandle<FocusForcedHighlightPersistentData>>();
			set => SetPropertyValue<CHandle<FocusForcedHighlightPersistentData>>(value);
		}

		public gameVisionModeComponentPS()
		{
			QuestForcedModules = new();
			QuestForcedMeshes = new();
		}
	}
}
