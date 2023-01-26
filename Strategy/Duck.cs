namespace Strategy
{
    public class Duck
    {
        private readonly IQuackBehavior quack;
        private readonly IFlyBehavior fly;

        public Duck(IFlyBehavior fly, IQuackBehavior quack)
        {
            this.fly = fly;
            this.quack = quack;
        }

        public string Quack()
        {
            return quack.Quack();
        }

        public string Fly()
        {
            return fly.Fly();
        }
    }
}