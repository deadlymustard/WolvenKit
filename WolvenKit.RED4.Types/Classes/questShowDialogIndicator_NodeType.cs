using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questShowDialogIndicator_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questShowDialogIndicator_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questShowDialogIndicator_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questShowDialogIndicator_NodeTypeParams>>(value);
		}

		public questShowDialogIndicator_NodeType()
		{
			Params = new() { new() };
		}
	}
}
