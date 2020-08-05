using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10
{
    namespace Task5
    {
        public interface INotification
        {
            void SendNotification();
        }

        public interface INotificationToDB
        {
            void AddNotificationToDB();
        }

        public interface INotificationToDBRead
        {
            void ReadNotification();
        }

        public class Customer
        {
            private INotification notification;

            public Customer(INotification notification)
            {
                this.notification = notification;
            }

            public void Register(string email, string password) { }

            public void SendNotification() =>
                notification.SendNotification();
        }

        public class MailService : INotification, INotificationToDB, INotificationToDBRead
        {
            public string Email { get; set; }
            public string EmailTitle { get; set; }
            public string EmailBody { get; set; }

            public void SendNotification() =>
                Console.WriteLine($"Mail:{Email}, Title:{EmailTitle}, Body:{EmailBody}");

            public void AddNotificationToDB() { }

            public bool ValidEmail() =>
                Email.Contains("@");

            public void ReadNotification() =>
                Console.WriteLine("ReadNotification");
        }

        public class SmsService : INotification
        {
            public string Number { get; set; }
            public string SmsText { get; set; }

            public void SendNotification() =>
                Console.WriteLine($"Number:{Number}, Message:{SmsText}");
        }
    }
}
