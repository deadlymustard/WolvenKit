using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkStyleResourceWrapper : ISerializable
	{
		[Ordinal(0)] 
		[RED("styleResource")] 
		public CResourceAsyncReference<inkStyleResource> StyleResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkStyleResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkStyleResource>>(value);
		}
	}
}
