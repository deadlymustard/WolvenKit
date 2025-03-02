using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_CollisionMeshes : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("prefabColor")] 
		public CColor PrefabColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("collisionMeshColor")] 
		public CColor CollisionMeshColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_CollisionMeshes()
		{
			DefaultColor = new();
			PrefabColor = new();
			CollisionMeshColor = new();
		}
	}
}
