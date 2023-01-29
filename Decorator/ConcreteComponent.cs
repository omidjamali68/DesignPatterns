namespace Decorator
{
    public class ConcreteComponent : Notifier
    {
        public override void Send(string message)
        {
            Console.WriteLine(message + " Sent with All services successfuly.");
        }
    }
}