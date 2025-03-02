using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitReactionCumulativeDamageUpdate : redEvent
	{
		[Ordinal(0)] 
		[RED("prevUpdateTime")] 
		public CFloat PrevUpdateTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
