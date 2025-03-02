using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MessageThreadReadEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("parentHash")] 
		public CInt32 ParentHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
