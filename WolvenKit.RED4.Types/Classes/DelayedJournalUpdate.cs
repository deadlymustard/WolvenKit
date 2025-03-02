using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedJournalUpdate : redEvent
	{
		[Ordinal(0)] 
		[RED("newMessageSpawned")] 
		public CBool NewMessageSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
