### **Question 1**

Create a class ReflectFields with public string field Name and three public int fields: MeasureX, MeasureY and MeasureZ.

Within this class define a public method OutputFields() which contains the loop through fields of the class ReflectFields and display  (in console) their names and values as the formatted string ("{0} (\<type>) = {1}", name, value). \<type> means the string representation of int or string type of field.

Note. System.Reflection provides a way to enumerate fields and properties. We get the FieldInfo objects for those fields and then display them.

After the values are set and the method is invoked the output:

```csharp
// set values.
ReflectFields.MeasureX = 100;
ReflectFields.MeasureY = 50;
ReflectFields.MeasureZ = 300;
ReflectFields.Name = "Programming";
// Invoke reflection methods.
ReflectFields.OutputFields();
```
**Name (string) = Programming<br/> 
MeasureX (int) = 100<br/>
MeasureY (int) = 50<br/>
MeasureZ (int) = 300**

### **Question 2**

Within the class ReflectMethod you have to:

1. Define the class Methods with three public static methods: Hello(), Welcome() and Bye(). Each of them takes a string parameter and provides the console output of formatted string according to its name:<br/> 
("Hello:parameter={0}", parameter)<br/> 
("Welcome:parameter={0}", parameter)<br/> 
("Bye:parameter={0}", parameter)

2. Define the public static method InvokeMethod() which takes the string array as parameter. 

The logic of method involves:

- to form a collection of methods from the class Methods, 

- to iterate over this collection by method name, 

- to invoke the method and pass it parameters from the array one by one.

The call of InvokeMethod() provides the output as follows:

```csharp
string[] parameters = {"Jhon", "Elly"};
ReflectMethod.InvokeMethod(parameters);
```
**Hello:parameter=Jhon<br/>
Hello:parameter=Elly<br/>
Welcome:parameter=Jhon<br/>
Welcome:parameter=Elly<br/>
Bye:parameter=Jhon<br/>
Bye:parameter=Elly**

### **Question 3**

Within the class ReflectProperties you have to:
1. create public class TestProperties with four properties:
    - public string FirstName;
    - internal string LastName;
    - protected int Age;
    - private string PhoneNumber.
2. define a method WriteProperties() that contains logic:
    - form the collection of the properties of TestProperties class;
    - iterate through the collection;
    - provide the console output of the name, type, read/write ability and accessibility level of every property.
The invoke of WriteProperties() method will cause the result:

**Property name: FirstName<br/>
Property type: System.String<br/>
Read-Write:    True<br/>
Accessibility: Public<br/>
<br/>
Property name: LastName<br/>
Property type: System.String<br/>
Read-Write:    True<br/>
Accessibility: Internal<br/>
<br/>
Property name: Age<br/>
Property type: System.Int32<br/>
Read-Write:    True<br/>
Accessibility: Protected<br/>
<br/>
Property name: PhoneNumber<br/>
Property type: System.String<br/>
Read-Write:    True<br/>
Accessibility: Private**

### **Question 4**
Within the class ReflectorAssembly you have to:

1. define three classes LargeBox, Box and SmallBox. Each of them contains two methods with string parameter size:

    -  UnPackingBox() outputs in console ("I am unpacking {0} box.", size);

    - InBox() - ("I am in {0} box.", size);

2. define two interfaces: 

    - ILookingForBox with method LookForBox() takes string parameter;

    - IPackingBox with method PackBox takes string parameter.

3. define the method WriteAssemblies() which contains the following logic:

    - get calling assembly;

    - get all types within assembly;

    - iterating through the collection of types;

    - providing the output is it class, method or interface and name of the type;

    - all methods of the class have to be invoked with the parameter according to the name of the class.

Note. You have to exclude classes Task and Reflector (with their methods) from the output.

The result of the method WriteAssemblies() invoking:

**Class: ReflectorAssembly<br/>
Class: LargeBox<br/>
Method: WriteAssemblies<br/>
Method: UnPackingBox<br/>
I am unpacking large box.<br/>
Method: InBox<br/>
I am in large box.<br/>
Class: Box<br/>
Method: UnPackingBox<br/>
I am unpacking middle box.<br/>
Method: InBox<br/>
I am in middle box.<br/>
Class: SmallBox<br/>
Method: UnPackingBox<br/>
I am unpacking small box.<br/>
Method: InBox<br/>
I am in small box.<br/>
Interface: ILookingForBox<br/>
Method: LookForBox<br/>
Interface: IPackingBox<br/>
Method: PackBox**

### **Question 5**

Within the class ReflectFullClass define a method WriteAllInClass(). The method will take one parameter of Type type (f.e. class). 

The method outputs a greeting with the class and allows to iterate through class and output the names of all custom members of the class (fields, properties, methods), interfaces that might be implemented and total quantity of every member and interfaces.

The probable result of invoking:

```csharp
ReflectFullClass.WriteAllInClass(typeof(MyClass));
```

**Hello, MyClass!<br/>
There are 2 fields in MyClass:<br/>
myfieldOne, myfieldTwo,<br/>
There are 3 properties in MyClass:<br/>
myPropertyOne, myPropertyTwo, myPropertyThree,<br/>
There are 2 methods in MyClass:<br/>
myMethodOne, myMethodTwo,<br/>
There are 3 interfaces in MyClass:<br/>
ImyInterfaceOne, ImyInterfaceTwo, ImyInterfaceThree,**