using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryRipperdocDisplayController : InventoryItemDisplayController
	{
		[Ordinal(80)] 
		[RED("ownedBackground")] 
		public inkWidgetReference OwnedBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(81)] 
		[RED("ownedSign")] 
		public inkWidgetReference OwnedSign
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public InventoryRipperdocDisplayController()
		{
			OwnedBackground = new();
			OwnedSign = new();
		}
	}
}
