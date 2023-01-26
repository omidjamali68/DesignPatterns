namespace Strategy
{
    public class NoQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "I Can't Quack";
        }
    }
}