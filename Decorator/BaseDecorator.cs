namespace Decorator
{
    public abstract class BaseDecorator : Notifier
    {
        private readonly Notifier warppe;

        public BaseDecorator(Notifier wrappe)
        {
            warppe = wrappe;
        }

        public override void Send(string message)
        {
            warppe.Send(message);
        }
    }
}