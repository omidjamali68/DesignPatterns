namespace Strategy
{
    public class SimpleQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "I Quack Simple";
        }
    }
}