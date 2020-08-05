### **Question 1**

Little boy Jimmy likes his pets and is found of programming.

Jimmy has cat Tom, duck McDuck, sparrow Sparry and parrot Leya. Jimmy decided to write a program to have a little report about pets' habits. 

But Leya is very clever parrot. She knows about SOLID principles and LSP she loves most of all. She didn't like the Jimmy's code. So she mixed all the classes, methods and interfaces.

At least Jimmy has only identifiers: Bird, Cat, Parrot, Duck, IFlyable, IEating, IMoving, Fly, Eat, Move, IBasking, IKryaking, Bask, Krya. And he remembers that every method have to output one habit of one pet.

By the way, Leya, like every good parrot, likes to imitate the habits of every Jimmy's pet.

### **Question 2**

An Invoice class might have the responsibility of calculating various amounts based on its data. In that case it probably shouldn’t know about how to retrieve this data from a database, or how to format an invoice for print or display or logging, sending Email etc.

So in the answer preload you can see Invoice class that contains almost the whole probable logic. This Invoice class  has his own responsibility i.e. Add, Delete invoice and also has extra activity like logging and Sending email as well.

You have to make the refactoring according to the SRP so that Invoice class can happily delegate additional activities to another types. This way Invoice class can concentrate on Invoice related activities.

### **Question 3**

Let's look at answer box preload. 

You have a class Invoice here  with a simple InvoiceType property. This property decided if this is a “Final” Or “Proposed” invoice. Depending on the same it calculates discount.  

Have a look at the GetDiscount() method which returns discount accordingly to the value of InvoiceType property .

The problem is if we add a new invoice type RecurringInvoice with the 10% discount, we need to go and add one more “IF” condition in the GetDiscount() method. In other words we need to change the Invoice class.

Among all a client wants to know the ordinary discount 1% of amount in times of season sale.

If we are changing the Invoice class again and again, we need to ensure that the previous conditions with new one’s are tested again , existing client’s which are referencing this class are working properly as before.  So whatever is the current code they are untouched and we just need to test and check the new classes.

Let’s refactor the solution.

### **Question 4**

Based on specifications, we need to create an interface ILead and a TeamLead class to implement it.

Later another role like Manager, who assigns tasks to TeamLead and will not work on the tasks, is introduced into the system. We tried to implement an ILead interface in the Manager class directly.

Here we are forcing the Manager class to implement a WorkOnTask() method without a purpose. This is wrong. The design violates ISP. 

But later one more role appears: Programmer that can only work on tasks. We need to divide the responsibilities by segregating the ILead interface. 

Your task is to refactor solution.

### **Question 5**

Suppose we need to work on an error logging module that logs exception stack traces into a file. You see this solution in the answer box preload.

The following are the classes that provide functionality to log a stack trace into a file. Among this it provide the storage of this stack trace in a database if an IO exception occurs.

But whenever the client wants to introduce a new logger, we need to alter ExceptionLogger by adding a new method. If we continue doing this after some time then we will see a fat ExceptionLogger class with a large set of methods that provide the functionality to log a message into various targets. 

Why does this issue occur? Because ExceptionLogger directly contacts the low-level classes FileLogger and DbLogger to log the exception. We need to alter the design so that this ExceptionLogger class can be loosely coupled with those class. To do that we need to introduce an abstraction between them, so that ExcetpionLogger can contact the abstraction to log the exception instead of depending on the low-level classes directly.

Your task is to refactor solution. You have to move to the low-level class’s initiation from the ExcetpionLogger class to the DataExporter class to make ExceptionLogger loosely coupled with the classes FileLogger and DBLogger. And by doing that we are giving provision to DataExporter class to decide what kind of Logger should be called based on the exception that occurs.