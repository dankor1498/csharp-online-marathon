using System;

namespace Sprint10
{
    namespace Task2
    {
        public class Customer
        {
            public static void Register(string email, string password)
            {
                MailService ms = new MailService(email, "User registration", "Body of message...");
                SmsService ss = new SmsService("111 111 111", "User succesfully registered...");
                try
                {
                    if (ms.ValidEmail())
                        ms.SendNotification();
                    ss.SendNotification();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        public abstract class NotificationService
        {
            public abstract void SendNotification();
        }

        public class MailService : NotificationService
        {
            public MailService(string email, string emailTitle, string emailBody)
            {
                Email = email;
                EmailTitle = emailTitle;
                EmailBody = emailBody;
            }

            public string Email { get; set; }
            public string EmailTitle { get; set; }
            public string EmailBody { get; set; }

            public override void SendNotification() =>
                Console.WriteLine($"Mail:{Email}, Title:{EmailTitle}, Body:{EmailBody}");

            public bool ValidEmail() =>
                Email.Contains("@");
        }

        public class SmsService : NotificationService
        {
            public SmsService(string number, string smsText)
            {
                Number = number;
                SmsText = smsText;
            }

            public string Number { get; set; }
            public string SmsText { get; set; }

            public override void SendNotification() =>
                Console.WriteLine($"Number:{Number}, Message:{SmsText}");
        }
    }
}
