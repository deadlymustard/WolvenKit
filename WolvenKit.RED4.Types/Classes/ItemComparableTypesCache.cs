using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemComparableTypesCache : IScriptable
	{
		[Ordinal(0)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(1)] 
		[RED("itemTypeRecord")] 
		public CWeakHandle<gamedataItemType_Record> ItemTypeRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataItemType_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataItemType_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("comparableTypes")] 
		public CArray<CEnum<gamedataItemType>> ComparableTypes
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		[Ordinal(3)] 
		[RED("comparableRecordTypes")] 
		public CArray<CWeakHandle<gamedataItemType_Record>> ComparableRecordTypes
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataItemType_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataItemType_Record>>>(value);
		}

		public ItemComparableTypesCache()
		{
			ComparableTypes = new();
			ComparableRecordTypes = new();
		}
	}
}
