using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleQuestChangeDoorStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetPropertyValue<CEnum<vehicleEVehicleDoor>>();
			set => SetPropertyValue<CEnum<vehicleEVehicleDoor>>(value);
		}

		[Ordinal(1)] 
		[RED("newState")] 
		public CEnum<vehicleEQuestVehicleDoorState> NewState
		{
			get => GetPropertyValue<CEnum<vehicleEQuestVehicleDoorState>>();
			set => SetPropertyValue<CEnum<vehicleEQuestVehicleDoorState>>(value);
		}
	}
}
