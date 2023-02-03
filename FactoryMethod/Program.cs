using FactoryMethod;

var domesticAnimal = new DomesticCreator().Create();
domesticAnimal.Operation();
// Return
// I'm a Cat

var wildAnimal = new WildCreator().Create();
wildAnimal.Operation();
// Return
// I'm a Lion