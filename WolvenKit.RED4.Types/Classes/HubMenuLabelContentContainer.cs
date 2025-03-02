using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HubMenuLabelContentContainer : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("desiredSizeWrapper")] 
		public inkWidgetReference DesiredSizeWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("border")] 
		public inkBorderWidgetReference Border
		{
			get => GetPropertyValue<inkBorderWidgetReference>();
			set => SetPropertyValue<inkBorderWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("carouselPosition")] 
		public CInt32 CarouselPosition
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("labelName")] 
		public CString LabelName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public MenuData Data
		{
			get => GetPropertyValue<MenuData>();
			set => SetPropertyValue<MenuData>(value);
		}

		public HubMenuLabelContentContainer()
		{
			Label = new();
			Icon = new();
			DesiredSizeWrapper = new();
			Border = new();
			Data = new() { Identifier = -1, SubMenus = new() };
		}
	}
}
