using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MovableDevice : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("workspotSideName")] 
		public CName WorkspotSideName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(98)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(99)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>(value);
		}

		[Ordinal(100)] 
		[RED("offMeshConnectionsToOpenNames")] 
		public CArray<CName> OffMeshConnectionsToOpenNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(101)] 
		[RED("offMeshConnectionsToOpen")] 
		public CArray<CHandle<AIOffMeshConnectionComponent>> OffMeshConnectionsToOpen
		{
			get => GetPropertyValue<CArray<CHandle<AIOffMeshConnectionComponent>>>();
			set => SetPropertyValue<CArray<CHandle<AIOffMeshConnectionComponent>>>(value);
		}

		[Ordinal(102)] 
		[RED("additionalMeshComponent")] 
		public CHandle<entMeshComponent> AdditionalMeshComponent
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(103)] 
		[RED("UseWorkspotComponentPosition")] 
		public CBool UseWorkspotComponentPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(104)] 
		[RED("shouldMoveRight")] 
		public CBool ShouldMoveRight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MovableDevice()
		{
			ControllerTypeName = "MovableDeviceController";
			SideTriggerNames = new();
			TriggerComponents = new();
			OffMeshConnectionsToOpenNames = new();
			OffMeshConnectionsToOpen = new();
		}
	}
}
