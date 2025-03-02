using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleMinimapMappinComponent : IScriptable
	{
		[Ordinal(0)] 
		[RED("minimapPOIMappinController")] 
		public CWeakHandle<MinimapPOIMappinController> MinimapPOIMappinController
		{
			get => GetPropertyValue<CWeakHandle<MinimapPOIMappinController>>();
			set => SetPropertyValue<CWeakHandle<MinimapPOIMappinController>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleIsLatestSummoned")] 
		public CBool VehicleIsLatestSummoned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("vehicleEntityID")] 
		public entEntityID VehicleEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(3)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get => GetPropertyValue<CHandle<VehicleSummonDataDef>>();
			set => SetPropertyValue<CHandle<VehicleSummonDataDef>>(value);
		}

		[Ordinal(4)] 
		[RED("vehicleSummonDataBB")] 
		public CWeakHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(5)] 
		[RED("vehicleSummonStateCallback")] 
		public CHandle<redCallbackObject> VehicleSummonStateCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public VehicleMinimapMappinComponent()
		{
			VehicleEntityID = new();
		}
	}
}
