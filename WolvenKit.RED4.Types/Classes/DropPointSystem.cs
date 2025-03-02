using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPointSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("packages")] 
		public CArray<CHandle<DropPointPackage>> Packages
		{
			get => GetPropertyValue<CArray<CHandle<DropPointPackage>>>();
			set => SetPropertyValue<CArray<CHandle<DropPointPackage>>>(value);
		}

		[Ordinal(1)] 
		[RED("mappins")] 
		public CArray<CHandle<DropPointMappinRegistrationData>> Mappins
		{
			get => GetPropertyValue<CArray<CHandle<DropPointMappinRegistrationData>>>();
			set => SetPropertyValue<CArray<CHandle<DropPointMappinRegistrationData>>>(value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DropPointSystem()
		{
			Packages = new();
			Mappins = new();
			IsEnabled = true;
		}
	}
}
