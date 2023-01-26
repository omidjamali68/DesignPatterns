using System;

namespace Adapter
{
    public class External_SMS_Library
    {
        // cannot inherit Notification Interface
        // because it is third party library
        // and it has own code
        internal void Login()
        {
            Console.WriteLine("Sms Service Logedin...");
        }

        internal void SetPort()
        {
            Console.WriteLine("Sms Service Port Seted...");
        }

        internal void SendSms(string Text)
        {
            Console.WriteLine( $"Sms With Text: {Text} Sent...");
        }
    }
}