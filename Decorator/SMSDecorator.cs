namespace Decorator
{
    public class SMSDecorator : BaseDecorator
    {
        public SMSDecorator(Notifier wrappe) : base(wrappe)
        {
        }

        public override void Send(string message)
        {
            SendMessage(message);
            base.Send(message);
        }

        private static void SendMessage(string message)
        {
            // do some implemention for send message with SMS service
            Console.WriteLine(message + " Sent via SMS service.");
        }
    }
}