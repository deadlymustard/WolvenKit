using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Quad : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("p1")] 
		public Vector4 P1
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("p2")] 
		public Vector4 P2
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("p3")] 
		public Vector4 P3
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("p4")] 
		public Vector4 P4
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public Quad()
		{
			P1 = new();
			P2 = new();
			P3 = new();
			P4 = new();
		}
	}
}
