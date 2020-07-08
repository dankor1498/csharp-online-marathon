### **Question 1**

Create class Employee.

Create two derived classes: Developer and Tester.

Class Employee should contain internal string field name and private DateTime field hiringDate.

Class Developer should contain private string field programmingLanguage.

Class Tester should contain private bool field isAuthomation.

Class Employee should contain public constructor that accepts two arguments (name and hiringDate).

Class Employee should contain public int method Experience() that calculates the count off full years of experience. This method should be the same for the derived classes.

Class Tester should contain the constructor that accepts three arguments: name, hiringDate and isAuthomation.

Class Developer should contain the constructor that accepts three arguments: name, hiringDate and programmingLanguage.

Class Employee should contain public void method ShowInfo() that prints the such string:

"\<name> has \<Experience> years of experience".

Class Developer should contain public void method ShowInfo() that prints the such string:

"\<name> has \<Experience> years of experience.

\<name> is \<programmingLanguage> programmer".

Please, pay attention that the first line as the same as for appropriate Employee’s method.

Class Tester should contain public void method ShowInfo() that prints the such string

“\<name> is authomated tester and has \<Experience> year(s) of experience”

If isAuthomated field is true

Or

“\<name> is manual tester and has \<Experience> year(s) of experience”

If isAuthomated field is false.

### **Question 2**

Create abstract class Car and two derived classes: SportCar and Lory.

Class Car should have the next fields: internal string mark, internal int prodYear.

Class SportCar should have the next fields: internal string mark, internal int prodYear, private int maxSpeed.

Class Lory should have internal string mark, internal int prodYear and private double loadCapacity.

Create also appropriable constructors that allow create class instances with all the fields.

Every class should have public void method ShowInfo().

For class Car this method should display message:

“Mark : \<mark>,

Producted in \<prodYear>”

For SportCar this method should display message:

“Mark : \<mark>,

Producted in \<prodYear>

Maximum speed is \<maxSpeed>”

For Lory this method should display message:

“Mark : \<mark>,

Producted in \<prodYear>

The load capacity is \<loadCapacity>”

Please organize the code optimally.

### **Question 3**

Create three classes: Science, Mathematics and Physics. Organize inheritance in the correct way.

Create method Awards() so that the next code

```csharp
Science science1 = new Mathematics();
Science science2 = new Physics();
Science science2 = new Science();

science1.Awards();
science2.Awards();
science3.Awards();
```

Gives the next output

**We don't need any awards, but we still can obtain The Abel Prize that nobody else can!**

**We can obtain The Nobel Prize**

**We can obtain The Nobel Prize**

Keep your code as optimized as possible.

Tip: use virtual method.

### **Question 4**

Create three classes: ChessFigure, Bishop and Rook. Organize inheritance in the correct way.

Class Bishop should have void method Move() that outputs the message "Moves by a diagonal!".

Class Rook should have void method Move() that outputs the message "Moves straight!".

Every class that is derived from class ChessFifure must implement void method Move().

### **Question 5**

For finish, let’s talk about the cats. The big cats.

Please, create class Acinonychini. This class has two sub-classes, that live now: Acinonyx and Puma.

Create these sub-classes too. It’s known that Puma has sub-classed and they may be created later. Acinonyx has no sub-classed, so it’s sub-classes can’t be created anywhen.

Create For all the classes those fields, properties and methods that you think they need.