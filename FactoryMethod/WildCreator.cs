namespace FactoryMethod
{
    public class WildCreator : AnimalFactory
    {
        public override IAnimal Create()
        {
            return new Lion();
        }
    }
}