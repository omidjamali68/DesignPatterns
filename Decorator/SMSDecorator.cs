namespace Decorator
{
    public class SMSDecorator : BaseDecorator
    {
        public SMSDecorator(Notifier wrappe) : base(wrappe)
        {
        }

        public new void Send(string message)
        {
            sendMessage(message);
            base.Send(message);
        }

        private void sendMessage(string message)
        {
            // do some implemention for send message with SMS service
            Console.WriteLine(message + " Sent via SMS service.");
        }
    }
}