### **Question 1**

In class MyProgram:

1. Create a method that should take a collection of arguments Position(List<int> numbers) in which find and Console.WriteLine all positions of element 5 in this collection

2. Create a method that should take a collection of arguments Remove(List<int> numbers) in which remove from collection all elements, which are greater than 20. and print collection

3. Create a method that should take a collection of arguments Insert(List<int> numbers)  in which insert elements -5,-6,-7 in positions 3, 6, 8 and print collection

4. Create a method that should take a collection of arguments Sort(List<int> numbers) in which sorting collection with LINQ and print collection

### **Question 2**

You have the next Main realization: 

```csharp
var products = new List<Product>();
products.Add(new Product { Name = "SmartTV", Price = 400, Category = "Electronics" });
products.Add(new Product { Name = "Lenovo ThinkPad", Price = 1000, Category = "Electronics" });
products.Add(new Product { Name = "Iphone", Price = 700, Category = "Electronics" });
products.Add(new Product { Name = "Orange", Price = 2, Category = "Fruits" });
products.Add(new Product { Name = "Banana", Price = 3, Category = "Fruits" });
ILookup<string, Product> lookup = products.ToLookup(prod => prod.Category);
TotalPrice(lookup);
Console.ReadKey();
``` 

Please create a method TotalPrice(ILookup<string, Product> lookup) in which print (Name + " " + Price) from one category and total price for products from these categories (Key + " " + totalPriceForCategory)

For example:

**SmartTV 400**

**Lenovo ThinkPad 1000**

**Iphone 700**

**Electronics 2100**

**Orange 2**

**Banana 3**

**Fruits 5**

### **Question 3**

We have the next collection:  

```csharp
Dictionary<string, string> persons = new Dictionary<string, string>();
persons.Add("id11111", "Admin");
persons.Add("id12345", "User1");
persons.Add("id98765", "User2");
persons.Add("id56743", "User3");
persons.Add("id73920", "User4");
``` 

1. In class MyProgram please create a method that should take a collection of arguments SearchKeys(Dictionary<string, string> persons) in which print all keys from this collection

2. method that should take a collection of arguments SearchValues(Dictionary<string, string> persons) in which print all values from this collection

3. and method that should take a collection of arguments SearchAdmin(Dictionary<string, string> persons) in which search value "Admin" and print information in format Key + " " + Value 

### **Question 4**

Create a ListDictionaryCompare() method of the MyUtils class to compare the contents of a List of strings and the values of a Dictionary. 

For example, for a given list [aa, bb, aa, cc] and dictionary {1=cc, 2=bb, 3=cc, 4=aa, 5=cc} you should get true.

For a given list [aa, bb, aa, cc, ddd] and dictionary {1=cc, 2=bb, 3=cc, 4=aa, 5=cc} you should get false

For a given list [aa, bb, aa, cc] and dictionary {1=cc, 2=bb, 3=cc, 4=aa, 5=cc, 6=ddd} you should get false

### **Question 5**

Implement the ReverseNotebook() method that creates a new dictionary with name as key and list of phones as value.  The method receives a dictionary  with phone as key and name as value.

For example, for a given dictionary {0967654321=Petro, 0677654321=Petro, 0501234567=Ivan, 0970011223=Stepan, 0631234567=Ivan} you should get {Ivan=[0501234567, 0631234567], Petro=[0967654321, 0677654321], Stepan=[0970011223]}.

The method should work with entry notebook containing empty or null names without throwing exceptions. Use empty string as a key for null names.

### **Question 6**

Implement class Student: add the constructor (with field initializations) and necessary methods into it.

Add public static GetCommonStudents() method to Student class that returns a HashSet of common elements of two student lists.

For example, for a given list1 [Student [Id=1, Name=Ivan], Students [Id=2, Name=Petro], Students [Id=3, Name=Stepan]] and list2 [Student [Id=1, Name=Ivan], Students [Id=3, Name=Stepan], Students [Id=4, Name=Andriy]] you should get [Student [Id=3, name=Stepan], Students [Id=1, Name=Ivan]].
