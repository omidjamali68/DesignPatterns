namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mailer = new EmailNotification();
            NotifyUser(mailer);

            var sms = new External_SMS_Library();
            //NotifyUser(sms); ERROR : cannot convert from 'Adapter.External_SMS_Library' to 'Adapter.Notification' 

            var smsAdapter = new SmsAdapter(sms);
            NotifyUser(smsAdapter);
        }

        public static void NotifyUser(Notification notifier){
            notifier.Send();
        }
    }
}
