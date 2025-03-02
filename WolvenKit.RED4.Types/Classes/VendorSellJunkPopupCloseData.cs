using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorSellJunkPopupCloseData : inkGameNotificationData
	{
		[Ordinal(6)] 
		[RED("confirm")] 
		public CBool Confirm
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("items")] 
		public CArray<CWeakHandle<gameItemData>> Items
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameItemData>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameItemData>>>(value);
		}

		[Ordinal(8)] 
		[RED("limitedItems")] 
		public CArray<CHandle<VendorJunkSellItem>> LimitedItems
		{
			get => GetPropertyValue<CArray<CHandle<VendorJunkSellItem>>>();
			set => SetPropertyValue<CArray<CHandle<VendorJunkSellItem>>>(value);
		}

		public VendorSellJunkPopupCloseData()
		{
			Items = new();
			LimitedItems = new();
		}
	}
}
