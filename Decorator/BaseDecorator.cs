namespace Decorator
{
    public class BaseDecorator : Notifier
    {
        private Notifier warppe;

        public BaseDecorator(Notifier wrappe)
        {
            this.warppe = wrappe;
        }

        public override void Send(string message)
        {
            warppe.Send(message);
        }
    }
}