using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DataTerm : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("linkedFastTravelPoint")] 
		public CHandle<gameFastTravelPointData> LinkedFastTravelPoint
		{
			get => GetPropertyValue<CHandle<gameFastTravelPointData>>();
			set => SetPropertyValue<CHandle<gameFastTravelPointData>>(value);
		}

		[Ordinal(98)] 
		[RED("exitNode")] 
		public NodeRef ExitNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(99)] 
		[RED("fastTravelComponent")] 
		public CHandle<FastTravelComponent> FastTravelComponent
		{
			get => GetPropertyValue<CHandle<FastTravelComponent>>();
			set => SetPropertyValue<CHandle<FastTravelComponent>>(value);
		}

		[Ordinal(100)] 
		[RED("lockColiderComponent")] 
		public CHandle<entIPlacedComponent> LockColiderComponent
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(101)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(102)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(103)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public DataTerm()
		{
			ControllerTypeName = "DataTermController";
			MappinID = new();
			ShortGlitchDelayID = new();
		}
	}
}
