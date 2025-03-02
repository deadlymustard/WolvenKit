using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GenericMessageNotificationData : inkGameNotificationData
	{
		[Ordinal(6)] 
		[RED("identifier")] 
		public CInt32 Identifier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("type")] 
		public CEnum<GenericMessageNotificationType> Type
		{
			get => GetPropertyValue<CEnum<GenericMessageNotificationType>>();
			set => SetPropertyValue<CEnum<GenericMessageNotificationType>>(value);
		}

		[Ordinal(8)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
