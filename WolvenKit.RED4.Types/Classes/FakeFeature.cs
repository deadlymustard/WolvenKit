using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FakeFeature : gameObject
	{
		[Ordinal(40)] 
		[RED("choices")] 
		public CArray<SFakeFeatureChoice> Choices
		{
			get => GetPropertyValue<CArray<SFakeFeatureChoice>>();
			set => SetPropertyValue<CArray<SFakeFeatureChoice>>(value);
		}

		[Ordinal(41)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(42)] 
		[RED("components")] 
		public CArray<CHandle<entIPlacedComponent>> Components
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(43)] 
		[RED("scaningComponent")] 
		public CHandle<gameScanningComponent> ScaningComponent
		{
			get => GetPropertyValue<CHandle<gameScanningComponent>>();
			set => SetPropertyValue<CHandle<gameScanningComponent>>(value);
		}

		[Ordinal(44)] 
		[RED("was_used")] 
		public CBool Was_used
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FakeFeature()
		{
			Choices = new();
			Components = new();
		}
	}
}
