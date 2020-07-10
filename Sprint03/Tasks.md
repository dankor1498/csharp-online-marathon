### **Question 1**

Create a program that can be used for calculation of 4 arithmetic operations (+, -, *, /) according to tasks:

1. declare a delegate CalcDelegate referring to a function Calc with three parameters (two numbers and one - operation sign) and a numerical result;

2. define a class CalcProgram and within this class:

   1. define a static function Calc  for computation with the same signature as the delegate. Note: in case of denominator=0, the function returns 0.

   2. create a delegate's method funcCalc and pass the function Calc as an argument.

### **Question 2**

Define a class StringExtensions with an extension method WordCount(…) for class String that counts the number of words in a given string. 

### **Question 3**

Define a static method ListWithPositive that receives the generic List as a parameter. The List will consist of negative and positive elements.

The method  ListWithPositive uses the FindAll method on the List type, which requires a delegate instance that receives one integer and returns a boolean. The argument to FindAll will use the anonymous method syntax.

Validate the argument using if-statement. If the element is less then or equal 0 or greater then 10, the predicate in FindAll will return 'false'.

The predicate in FindAll will use a boolean expression that is evaluated, causing the anonymous function to return true if the argument is positive and less then or equal 10.

The method  ListWithPositive returns the list of positive elements.

### **Question 4**

Define a class IListExtensions with an extension method IncreaseWith(…) that takes an instance of a class, that implements the interface list of integers (IList<int>), and increases their value by a certain number. The method can access only those elements that are included in the interface IList.

Define a class  IEnumerableExtensions with, an extension method ToString() that implementing  IEnumerable from generic type T. 

ToString() loops through a collection and converts a sequence of elements (list of integers) to a meaningful string.

Use IncreaseWith() and ToString() extension methods in such a way:
```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine(numbers.ToString<int>());
numbers.IncreaseWith(5); 
Console.WriteLine(numbers.ToString<int>());
```
Output:

**[1, 2, 3, 4, 5]**

**[6, 7, 8, 9, 10]**

### **Question 5**

Define an event  Show of EventHandler type.

Define four static methods: Dog(), Cat(), Mouse(), Elephant(). Each method outputs the corresponding inscription of an animal: "Dog", "Cat", "Mouse" or "Elephant".

Define the class EventProgram and constructor with these four method instances added to the invocation list of Show event. Invoke event out of the constructor. 

