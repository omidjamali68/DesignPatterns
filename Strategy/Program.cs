using Strategy;

var simpleFly = new SimpleFly();
var noQuack = new NoQuack();
var cityDuck = new Duck(simpleFly, noQuack);
Console.WriteLine("I'm a city duck and " +
    cityDuck.Fly() + " and " + cityDuck.Quack());

var jetFly = new JetFly();
var simpleQuack = new SimpleQuack();
var mountainDuck = new Duck(jetFly, simpleQuack);
Console.WriteLine("I'm a mountain duck and " +
    mountainDuck.Fly() + " and " + mountainDuck.Quack());

// results
// I'm a city duck and I Fly Simple and I Can't Quack
// I'm a mountain duck and I Fly Like a Jet and I Quack Simple