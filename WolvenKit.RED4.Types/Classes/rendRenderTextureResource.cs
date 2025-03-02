using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderTextureResource : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("renderResourceBlobPC")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlobPC
		{
			get => GetPropertyValue<CHandle<IRenderResourceBlob>>();
			set => SetPropertyValue<CHandle<IRenderResourceBlob>>(value);
		}
	}
}
