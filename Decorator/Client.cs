namespace Decorator
{
    public static class Client
    {
        public static void ClientCode(Notifier wrappe, string message)
        {
            wrappe.Send(message);
        }
    }
}