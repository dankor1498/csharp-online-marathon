using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10
{
    namespace Task4
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
            public static void Register(string email, string password)
            {
                MailService ms = new MailService(email, "User registration", "Body of message...");
                SmsService ss = new SmsService("111 111 111", "User successfully registered...");
                try
                {
                    if (ms.ValidEmail())
                    {
                        ms.SendNotification();
                    }
                    ss.SendNotification();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        public class MailService : INotification, INotificationToDB, INotificationToDBRead
        {
            public string Email { get; set; }
            public string EmailTitle { get; set; }
            public string EmailBody { get; set; }

            public MailService(string email, string emailTitle, string emailBody)
            {
                Email = email;
                EmailTitle = emailTitle;
                EmailBody = emailBody;
            }

            public void SendNotification() =>
                Console.WriteLine($"Mail:{Email}, Title:{EmailTitle}, Body:{EmailBody}");

            public void AddNotificationToDB() =>
                Console.WriteLine($"Mail:{Email}, Title:{EmailTitle}, Body:{EmailBody}");

            public bool ValidEmail() =>
                Email.Contains("@");

            public void ReadNotification()=>
                Console.WriteLine("ReadNotification");
        }

        public class SmsService : INotification
        {
            public string Number { get; set; }
            public string SmsText { get; set; }

            public SmsService(string number, string smsText)
            {
                Number = number;
                SmsText = smsText;
            }

            public void SendNotification() =>
                Console.WriteLine($"Number:{Number}, Message:{SmsText}");
        }
    }
}
