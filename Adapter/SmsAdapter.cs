namespace Adapter
{
    public class SmsAdapter : Notification
    {
        private External_SMS_Library smsLibraryService;
        public SmsAdapter(External_SMS_Library external_SMS_Library)
        {
            this.smsLibraryService = external_SMS_Library;
        }

        public void Send()
        {
            smsLibraryService.Login();
            smsLibraryService.SetPort();
            smsLibraryService.SendSms("Test Text");
        }
    }
}