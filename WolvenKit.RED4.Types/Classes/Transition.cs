using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Transition : redEvent
	{
		[Ordinal(0)] 
		[RED("listenerID")] 
		public CUInt32 ListenerID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
