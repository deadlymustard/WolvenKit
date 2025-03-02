using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootSlot : gameLootContainerBase
	{
		[Ordinal(50)] 
		[RED("immovableAfterDrop")] 
		public CBool ImmovableAfterDrop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("dropChance")] 
		public CFloat DropChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("lootState")] 
		public CBitField<gameLootSlotState> LootState
		{
			get => GetPropertyValue<CBitField<gameLootSlotState>>();
			set => SetPropertyValue<CBitField<gameLootSlotState>>(value);
		}

		public gameLootSlot()
		{
			DropChance = 1.000000F;
		}
	}
}
