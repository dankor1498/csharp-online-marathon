### **Question 1**

Consider this class:

```csharp
public class Customer
{
    public void Register(string email, string password)
    {
        try
        {
            //code for registering user
            if (ValidEmail(email))
            {
                SendEmail(email, "Email title", "Email body");
            }
        }
        catch (Exception ex)
        {
            //log if error occurs
            throw;
        }
    }

    public bool ValidEmail(string email)
    {
        return email.Contains("@");
    }

    public void SendEmail(string mail, string emailTitle, string emailBody)
    {
        Console.WriteLine($"Mail: {mail} Title: {emailTitle} Body: {emailBody}");
    }
}
```

Following SRP principle, the responsibility of the Customer class should be only the Register method. The Customer class should not worry with the definition of Validation Rules of the Email address and sending messages.

Please change the class Customer and create the class MailService following the SRP principle.

### **Question 2**

Consider the class Customer from the previous  task (1) with the SRP principle applied. 

```csharp
public class Customer
{
    public void Register(string email, string password)
    {
        MailService ms = new MailService();
        try
        {
            //code for registering user
            if (ms.ValidEmail(email))
            {
                ms.SendEmail(email, "Email title", "Email body");
            }
        }
        catch (Exception ex)
        {
            //log if error occurs
            throw;
        }
    }
}
```
Let’s say that we want to add additional functionality. After user registration  we want to send email and sms to that user. According to the SRP principle we would add additional classes. You have to create:

1. public abstract class NotificationService with abstract method SendNotification().

2. public class MailService (inherited from class NotificationService) with:

    - three string properties: Email, EmailTitle and EmailBody;

    - boolean method ValidEmail() that returns True if the Email contains "@";

    - overriden method  SendNotification() that output in console formatted string ("Mail:{0}, Title:{1}, Body:{2}", Email, EmailTitle, EmailBody).

3. public class SmsService (inherited from class NotificationService) with:

    - two string properties Number, SmsText;

    - overriden method  SendNotification() that output in console formatted string ("Number:{0}, Message:{1}", Number, SmsText).

### **Question 3**

Consider the previous tasks (1) and (2) with the SRP and OCP principles applied. Let’s say that we want to add additional functionality to the NotificationService class for writing notification records to Database but this records to be only for emails.

Above code in the Customer class will fail because of the AddNotificationToDB method in the smsService class called. One solution is not to call the above method but we raise another problem. We have a class that implements method that is not used. According to LSP you have to ensure that new derived classes extend the base classes without changing their behavior.

Your task is to fix this issue by the implementation in the following way:

- create an interface INotification with the method SendNotification();

- create an interface INotificationToDB with the method AddNotificationToDB();

- the class MailService have to implement both interfaces INotification and INotificationToDB;

- the class SmsService have to implement INotification;

- change the class Customer. You may comment the code that uses the call of method AddNotificationToDB().

Note. You may use the console notification from method  SendNotification() in the classes MailService and SmsService as it was described in previous tasks.

### **Question 4**

According to the previous tasks (1), (2), (3) let’s say that we want to add additional functionality to the Notification interface for Reading notification from Database.

With this definition we obligate the class that inherits from this interface to implement the method for reading notification. Maybe in some cases we don’t want to have this but because of the inheritance we need to define the method in the class even if we don’t want to implement this. The solution for this problem is to separate all the methods that are not used everywhere in a separate interface like as follows:

- change the interface INotificationToDB and leave only one method in it (as you consider);

- create the interface INotificationToDBRead and define one method in it  (as you consider);

- the class MailService will implement three interfaces: INotification, INotificationToDB, INotificationToDBRead. Each of the methods of these interfaces will output some message into console;

- change class Customer if you need.

### **Question 5**

From the previous tasks (1) - (4) we had the following situations with the Customer class.
We have a lot of code here. DIP says that high-level modules/classes should not depend upon low-level modules/classes. Both should depend upon abstractions. Secondly, abstractions should not depend upon details. Details should depend upon abstractions

Let’s isolate this class Customer as a separate component. You have to define within this class

- the constructor with INotification parameter;

- leave method Register() with two string input parameters email and password. Leave only empty "try ... catch ..." statement in the body of method;

- leave method SendNotification() with INotification notification parameter. It will initiate the console output of notification (as in the previous tasks).

Classes MailService, SmsService and interfaces INotification, INotificationToDB and INotificationToDBRead use without any change.