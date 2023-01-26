using System;

namespace Adapter
{
    public class EmailNotification : Notification
    {
        public void Send()
        {
            Console.WriteLine("Email Sent....");
        }
    }
}