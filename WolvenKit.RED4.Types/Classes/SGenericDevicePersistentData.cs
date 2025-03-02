using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SGenericDevicePersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("genericActions")] 
		public SGenericDeviceActionsData GenericActions
		{
			get => GetPropertyValue<SGenericDeviceActionsData>();
			set => SetPropertyValue<SGenericDeviceActionsData>(value);
		}

		[Ordinal(1)] 
		[RED("customActions")] 
		public SCustomDeviceActionsData CustomActions
		{
			get => GetPropertyValue<SCustomDeviceActionsData>();
			set => SetPropertyValue<SCustomDeviceActionsData>(value);
		}

		public SGenericDevicePersistentData()
		{
			GenericActions = new() { ToggleON = new(), TogglePower = new() };
			CustomActions = new() { Actions = new() };
		}
	}
}
