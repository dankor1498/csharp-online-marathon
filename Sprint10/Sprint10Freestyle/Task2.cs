using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10Freestyle
{
    namespace Task2
    {
        public interface IFileLogger
        {
            public void Check();
            public void Debug();
            public void Info();
        }

        public interface IMailSender
        {
            public void SendEmail(string mailMessage);
        }

        public class MailSender : IMailSender
        {
            public string From { get; set; }
            public string To { get; set; }
            public string Subject { get; set; }

            public void SendEmail(string mailMessage) =>
                Console.WriteLine("Sending Email: {0}", mailMessage);
        }

        public class FileLogger : IFileLogger
        {
            public void Check() { }
            public void Debug() { }
            public void Info() { }
        }

        public class Invoice
        {
            public string Body { get; set; }
            public long Amount { get; set; }
            public DateTime InvoiceDate { get; set; }

            public void Add()
            {
                Console.WriteLine("Adding amount...");
                string mailMessage = "Your invoice is ready.";
                new MailSender().SendEmail(mailMessage);
            }

            public void Delete() =>
                Console.WriteLine("Deleting amount...");
        }
    }
}
