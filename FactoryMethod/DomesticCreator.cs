namespace FactoryMethod
{
    public class DomesticCreator : AnimalFactory
    {
        public override IAnimal Create()
        {
            return new Cat();
        }
    }
}