using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAreaVolume : gameObject
	{
		[Ordinal(40)] 
		[RED("areaData")] 
		public gameAreaData AreaData
		{
			get => GetPropertyValue<gameAreaData>();
			set => SetPropertyValue<gameAreaData>(value);
		}

		public gameAreaVolume()
		{
			AreaData = new() { Position = new() { W = 1.000000F }, Size = 1.000000F };
		}
	}
}
