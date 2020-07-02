### **Question 1**

Please, create MyAccessModifiers class with next members:

int field birthYear is unavailable anywhere except this class

string field personalInfo that is accessible within descendants of this class

string field IdNumber that is accessible only within descendants in the current assembly

constructor should be available from everywhere in the program and accept int, string for idNumber, string for personalInfo parameters to initialize three fields mentioned above.

int property Age which returns the difference between the current year and birthYear and can be accessed everywhere, but only for reading

common for all instances of the class byte field averageMiddleAge with default value 50

string property Name accessible anywhere in the current assembly

string property NickName that can be read anywhere in the program and set only in the current assembly

method HasLivedHalfOfLife available only for descendants of the class in other assemblies and for all in the current.

overload operator ==. The operator returns true if name, age, and personalInfo  of objects are equal.

### **Question 2**

Create a Point class which models a 2D point with x and y coordinates should contain:

Two instance variables x and y  of int type, that will be available only in this class.

A constructor that constructs a point with the given x and y coordinates.

A method GetXYPair() which returns the x and y in a 2-element int array. This method should be available everywhere in the current assembly

A method called Distance(int x, int y) that returns the distance from this point to another point at the given (x, y) coordinates.

An overloaded Distance(Point point) method that returns the distance from this point to the given Point instance.

The distance methods should be available everywhere in the current assembly and in descendant classes in other assemblies;

Create explicit cast to double operator that returns the distance from this point to the origin (0, 0).

### **Question 3**

Create class Fraction with private int fields numerator and denominator that can only be initialized on creation or in constructor

Create a constructor to initialize these values

Define operators unary and binary + and - and ~ for inversion of fraction (1:fraction)

Define the ! operator that will return reversed fraction - with numerator as denominator and denominator as numerator

Define binary  * and / operations.

All operations should return simplified fractions.

Define ToString() method which will return string representing Fraction in the format numerator / denominator. 

Value should be simplified: numerator and denominator divided by the greatest common divisor. 

if  numerator and denominator are both negative, the fraction should become positive. 

If only denominator is negative the sign should be outputted before numerator without space.

Define Equals  method and operators == and !=. Fractions are equal if their simplified versions are equal. 

(for example, 20/25 isequal to 4/5)

Define GetHashCode() method with implementation at your choise.

### **Question 4**

Suppose, you have class

```csharp
public abstract class CloseableResource 
{         
    public void Close()         
    {             
        //some closing actions         
    }          
    //some code     
}
```

Please, create class DisposePatternImplementer that implements Disposable pattern and inherits from CloseableResource class

Print such lines of information in the method responsible for releasing managed and unmanaged resources:

"Disposing by developer" if the object of the class is disposed by developer

or "Disposing by GC" if the object is disposed by garbage collector

also, you should ensure that method Close() is called in either case.

### **Question 5**

Please, make refactoring of the code:

We know that adult  doesn't have childIDNumber 

child doesn't have passportNumber.

Create a public constructor in each class to initialize all their fields (make the first parameter of type int and the second one for name initialization).

Accessibility of the fields should be the least possible, but the same in all assemblies.

Add ToString() method to Child and Adult classes that will return a string in the format: "name document_number"
```csharp
public class Person
{
    protected string childIDNumber;
}

public class Child
{
    private int yearOfBirth;
    private string healthInfo;
    private string name;
    public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
}

public class Adult
{
    private int yearOfBirth;
    private string healthInfo;
    private string passportNumber;
    private string name;
    public string GetHealthStatus() {return name + ": " + yearOfBirth + ". " + healthInfo; }
}
```