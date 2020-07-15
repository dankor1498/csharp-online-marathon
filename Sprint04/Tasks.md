### **Question 1**

Define an Interface ISwimmable with declared method Swim() printinging the text "I can swim!" by default.

Define an interface IFlyable with read-only property MaxHeight returning 0 by default (use default implementation for this property).

In this interface, declare a method Fly() printing the text "I can fly at XX meters height!" by default, where XX is the value of MaxHeight property.

Define an interface IRunnable with read-only property MaxSpeed returning 0 by default (use default implementation for this property).

In this interface, declare a method Run() printing the text "I can run up to XX kilometers per hour!" by default, where XX is the value of MaxSpeed property.

Define an interface IAnimal with read-only property LifeDuration returning 0 by default (use default implementation for this property).

In this interface, declare a method Voice() printing the text "No voice!" by default.

Besides, declare a method ShowInfo() printing the text "I am a XX and I live approximately YY years." by default,
where XX is the name of the class implementing the interface,
YY is the value of LifeDuration property.

Define a class named Cat implementing the IAnimal and IRunnable interface.

In this class, implement autoproperties as needed.

Implement the Voice() method printing "Meow!"

Define a class named Eagle implementing the IAnimal and IFlyable interface.

In this class, implement autoproperties as needed.

Define a class named Shark implementing the IAnimal and ISwimmable interface.

In this class, implement autoproperties as needed.

### **Question 2**

Define an interface IAnimal with property Name, methods Voice() and Feed()

Define two classes Cat and Dog, which implement this interface.

For the class Dog,
the Voice() method should print "Woof" on the Console,
the Feed() method should print "I eat meat" on the Console.

For the class Cat,

the Voice() method should print "Mew" on the Console,
the Feed() method should print "I eat mice" on the Console.

### **Question 3**

Define ColourEnum enum consisting of 3 colours : red, green, blue (give names according to the convention).

Define an interface IColoured with read-only property Colour returning red colour by default (use default implementation for this property).

Define an interface IDocument with the following members:

- static field defaultText with the value "Lorem ipsum";

- public property Pages, which means the number of pages, with default implementation returning 0 by default;

- public property Name without default implementation (String);

- method AddPages with default implementation that increments the property Pages by the number which is input parameter of the method;

- method Rename with default implementation that changes the property Name to the one specified as input parameter of the method.

Define a class ColouredDocument implementing both interfaces above. The class should have public properties Name, Pages and Colour. Do not implement any methods in the class. Define a constructor for this class with colour parameter along with default constructor.

Define a class Example with a void static method Do. In this method, create an instance doc1 of the class ColouredDocument with Name="Document1". Change the name of the document to "Document2" using the Rename method. Print into console this property before and after renaming.

### **Question 4**

Define an Interface IShape with declared method Area() returning 0 by default (double type)

Define a class named Rectangle implementing the IShape interface.
In this class, define Length and Width properties(double type)
Implement the Area() method to calculate a rectangle area

Define a class named Trapezoid implementing the IShape interface.
In this class, define Length1, Length2 and Width properties(double type)
Implement the Area() method to calculate a trapezoid area

Define a generic class named Room<> depending on a shape of it's floor.
Impose a constraint for type argument of the Room generic class so that it should implement the IShape interface
In this class, define a Height property(double type) and the Floor property(type argument)
Implement the Volume() method to calculate a volume of the room.

Add an implementation of ICloneable interface for the Room<> class
Implement deep cloning

Add an implementation of IComparable interface for the Room<> class.
Implement a comparison by area of the floor.

Define a generic class RoomComparerByVolume<> implementing IComparer interface.
Impose a constraint on the type argument so that it should implement the IShape interface.
This comparer should perform comparison of rooms by room volume.