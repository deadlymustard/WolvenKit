using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Box : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Min")] 
		public Vector4 Min
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("Max")] 
		public Vector4 Max
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public Box()
		{
			Min = new();
			Max = new();
		}
	}
}
