namespace Decorator
{
    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(Notifier wrappe) : base(wrappe)
        {
        }

        public new void Send(string message)
        {
            sendMessage(message);
            base.Send(message);
        }

        private void sendMessage(string message)
        {
            // do some implemention for send message with slack
            Console.WriteLine(message + " Sent via Slack");
        }
    }
}