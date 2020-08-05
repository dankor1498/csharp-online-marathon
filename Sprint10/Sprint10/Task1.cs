using System;

namespace Sprint10
{
    namespace Task1
    {
        public interface IMailService
        {
            public bool ValidEmail(string email);
            public void SendEmail(string mail, string emailTitle, string emailBody);
        }

        public class MailService : IMailService
        {
            public bool ValidEmail(string email) =>
                email.Contains("@");

            public void SendEmail(string mail, string emailTitle, string emailBody) =>
                Console.WriteLine($"Mail: {mail} Title: {emailTitle} Body: {emailBody}");
        }

        public class Task1
        {
            public IMailService Service { get; set; }

            public Task1(IMailService service)
            {
                Service = service;
            }

            public void Register(string email, string password)
            {
                try
                {
                    if (Service.ValidEmail(email))
                        Service.SendEmail(email, "Email title", "Email body");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }
    }
}
