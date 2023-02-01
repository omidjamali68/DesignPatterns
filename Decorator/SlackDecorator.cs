namespace Decorator
{
    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(Notifier wrappe) : base(wrappe)
        {
        }

        public override void Send(string message)
        {
            SendMessage(message);
            base.Send(message);
        }

        private static void SendMessage(string message)
        {
            // do some implemention for send message with slack
            Console.WriteLine(message + " Sent via Slack");
        }
    }
}