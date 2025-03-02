using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemDisplayController : BaseButtonView
	{
		[Ordinal(2)] 
		[RED("widgetWrapper")] 
		public inkWidgetReference WidgetWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("itemPrice")] 
		public inkTextWidgetReference ItemPrice
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("itemRarity")] 
		public inkWidgetReference ItemRarity
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("commonModsRoot")] 
		public inkCompoundWidgetReference CommonModsRoot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("itemImage")] 
		public inkImageWidgetReference ItemImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("itemFallbackImage")] 
		public inkImageWidgetReference ItemFallbackImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("itemEmptyImage")] 
		public inkImageWidgetReference ItemEmptyImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("itemSelectedArrow")] 
		public inkWidgetReference ItemSelectedArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("quantintyAmmoIcon")] 
		public inkWidgetReference QuantintyAmmoIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("quantityWrapper")] 
		public inkCompoundWidgetReference QuantityWrapper
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("quantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("weaponType")] 
		public inkTextWidgetReference WeaponType
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("highlightFrames")] 
		public CArray<inkWidgetReference> HighlightFrames
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(16)] 
		[RED("equippedWidgets")] 
		public CArray<inkWidgetReference> EquippedWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(17)] 
		[RED("hideWhenEquippedWidgets")] 
		public CArray<inkWidgetReference> HideWhenEquippedWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(18)] 
		[RED("showInEmptyWidgets")] 
		public CArray<inkWidgetReference> ShowInEmptyWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(19)] 
		[RED("hideInEmptyWidgets")] 
		public CArray<inkWidgetReference> HideInEmptyWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(20)] 
		[RED("backgroundFrames")] 
		public CArray<inkWidgetReference> BackgroundFrames
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(21)] 
		[RED("requirementsWrapper")] 
		public inkWidgetReference RequirementsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("iconicTint")] 
		public inkWidgetReference IconicTint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("rarityWrapper")] 
		public inkWidgetReference RarityWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("rarityCommonWrapper")] 
		public inkWidgetReference RarityCommonWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("weaponTypeImage")] 
		public inkImageWidgetReference WeaponTypeImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("questItemMaker")] 
		public inkWidgetReference QuestItemMaker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("equippedMarker")] 
		public inkWidgetReference EquippedMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("labelsContainer")] 
		public inkCompoundWidgetReference LabelsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("backgroundBlueprint")] 
		public inkWidgetReference BackgroundBlueprint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("iconBlueprint")] 
		public inkWidgetReference IconBlueprint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("fluffBlueprint")] 
		public inkImageWidgetReference FluffBlueprint
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("lootitemflufficon")] 
		public inkWidgetReference Lootitemflufficon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("lootitemtypeicon")] 
		public inkImageWidgetReference Lootitemtypeicon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("slotItemsCountWrapper")] 
		public inkWidgetReference SlotItemsCountWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("slotItemsCount")] 
		public inkTextWidgetReference SlotItemsCount
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("iconErrorIndicator")] 
		public inkWidgetReference IconErrorIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("newItemsWrapper")] 
		public inkWidgetReference NewItemsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("newItemsCounter")] 
		public inkTextWidgetReference NewItemsCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("lockIcon")] 
		public inkWidgetReference LockIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("comparisionArrow")] 
		public inkWidgetReference ComparisionArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("inventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(42)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(43)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(44)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetPropertyValue<InventoryItemData>();
			set => SetPropertyValue<InventoryItemData>(value);
		}

		[Ordinal(45)] 
		[RED("recipeData")] 
		public CHandle<RecipeData> RecipeData
		{
			get => GetPropertyValue<CHandle<RecipeData>>();
			set => SetPropertyValue<CHandle<RecipeData>>(value);
		}

		[Ordinal(46)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(47)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(48)] 
		[RED("emptySlotImage")] 
		public CName EmptySlotImage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(49)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(50)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(51)] 
		[RED("attachmentsDisplay")] 
		public CArray<CWeakHandle<InventoryItemModSlotDisplay>> AttachmentsDisplay
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemModSlotDisplay>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemModSlotDisplay>>>(value);
		}

		[Ordinal(52)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(53)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get => GetPropertyValue<CEnum<gameItemDisplayContext>>();
			set => SetPropertyValue<CEnum<gameItemDisplayContext>>(value);
		}

		[Ordinal(54)] 
		[RED("labelsContainerController")] 
		public CWeakHandle<ItemLabelContainerController> LabelsContainerController
		{
			get => GetPropertyValue<CWeakHandle<ItemLabelContainerController>>();
			set => SetPropertyValue<CWeakHandle<ItemLabelContainerController>>(value);
		}

		[Ordinal(55)] 
		[RED("defaultFallbackImage")] 
		public CName DefaultFallbackImage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(56)] 
		[RED("defaultEmptyImage")] 
		public CName DefaultEmptyImage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(57)] 
		[RED("defaultEmptyImageAtlas")] 
		public CString DefaultEmptyImageAtlas
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(58)] 
		[RED("emptyImage")] 
		public CName EmptyImage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(59)] 
		[RED("emptyImageAtlas")] 
		public CString EmptyImageAtlas
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(60)] 
		[RED("enoughMoney")] 
		public CBool EnoughMoney
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("owned")] 
		public CBool Owned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("requirementsMet")] 
		public CBool RequirementsMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("tooltipData")] 
		public CHandle<InventoryTooltipData> TooltipData
		{
			get => GetPropertyValue<CHandle<InventoryTooltipData>>();
			set => SetPropertyValue<CHandle<InventoryTooltipData>>(value);
		}

		[Ordinal(64)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("newItemsIDs")] 
		public CArray<gameItemID> NewItemsIDs
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(66)] 
		[RED("newItemsFetched")] 
		public CBool NewItemsFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("isBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("parentItemData")] 
		public CWeakHandle<gameItemData> ParentItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(69)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("isUpgradable")] 
		public CBool IsUpgradable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("hasAvailableItems")] 
		public CBool HasAvailableItems
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("DEBUG_isIconError")] 
		public CBool DEBUG_isIconError
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetPropertyValue<CHandle<DEBUG_IconErrorInfo>>();
			set => SetPropertyValue<CHandle<DEBUG_IconErrorInfo>>(value);
		}

		[Ordinal(74)] 
		[RED("DEBUG_resolvedIconName")] 
		public CString DEBUG_resolvedIconName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(75)] 
		[RED("DEBUG_recordItemName")] 
		public CString DEBUG_recordItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(76)] 
		[RED("DEBUG_innerItemName")] 
		public CString DEBUG_innerItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(77)] 
		[RED("DEBUG_isIconManuallySet")] 
		public CBool DEBUG_isIconManuallySet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(78)] 
		[RED("DEBUG_iconsNameResolverIsDebug")] 
		public CBool DEBUG_iconsNameResolverIsDebug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(79)] 
		[RED("parrentWrappedDataObject")] 
		public CWeakHandle<WrappedInventoryItemData> ParrentWrappedDataObject
		{
			get => GetPropertyValue<CWeakHandle<WrappedInventoryItemData>>();
			set => SetPropertyValue<CWeakHandle<WrappedInventoryItemData>>(value);
		}

		public InventoryItemDisplayController()
		{
			WidgetWrapper = new();
			ItemName = new();
			ItemPrice = new();
			ItemRarity = new();
			CommonModsRoot = new();
			ItemImage = new();
			ItemFallbackImage = new();
			ItemEmptyImage = new();
			ItemSelectedArrow = new();
			QuantintyAmmoIcon = new();
			QuantityWrapper = new();
			QuantityText = new();
			WeaponType = new();
			HighlightFrames = new();
			EquippedWidgets = new();
			HideWhenEquippedWidgets = new();
			ShowInEmptyWidgets = new();
			HideInEmptyWidgets = new();
			BackgroundFrames = new();
			RequirementsWrapper = new();
			IconicTint = new();
			RarityWrapper = new();
			RarityCommonWrapper = new();
			WeaponTypeImage = new();
			QuestItemMaker = new();
			EquippedMarker = new();
			LabelsContainer = new();
			BackgroundBlueprint = new();
			IconBlueprint = new();
			FluffBlueprint = new();
			Lootitemflufficon = new();
			Lootitemtypeicon = new();
			SlotItemsCountWrapper = new();
			SlotItemsCount = new();
			IconErrorIndicator = new();
			NewItemsWrapper = new();
			NewItemsCounter = new();
			LockIcon = new();
			ComparisionArrow = new();
			ItemID = new();
			ItemData = new() { Empty = true, ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };
			EquipmentArea = Enums.gamedataEquipmentArea.Invalid;
			ItemType = Enums.gamedataItemType.Invalid;
			AttachmentsDisplay = new();
			DefaultFallbackImage = "undefined";
			DefaultEmptyImage = "icon_add";
			DefaultEmptyImageAtlas = "base\\gameplay\\gui\\fullscreen\\inventory\\inventory4_atlas.inkatlas";
			NewItemsIDs = new();
			HasAvailableItems = true;
		}
	}
}
