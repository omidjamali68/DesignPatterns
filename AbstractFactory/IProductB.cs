namespace AbstractFactory
{
    public interface IProductB
    {
        // Product B is able to do its own thing...
        public string UsefulFunctionB();

        // ...but it also can collaborate with the ProductA.
        //
        // The Abstract Factory makes sure that all products it creates are of
        // the same variant and thus, compatible.
        public string AnotherUsefulFunctionB(IProductA collaborator);
    }
}