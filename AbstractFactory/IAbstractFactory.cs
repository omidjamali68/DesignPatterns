namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        public IProductA CreateProductA();
        public IProductB CreateProductB();
    }
}