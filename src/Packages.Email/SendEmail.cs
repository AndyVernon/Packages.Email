using Email.Internal.Interfaces;
using Email.Models;

namespace Email
{
    public class SendEmail
    {
        private readonly IDataSecurerHelper _securerHelper;

        public SendEmail(IDataSecurerHelper securerHelper)
        {
            _securerHelper = securerHelper;
        }

        public void Send(string sender, string recipient, string subject, string body)
        {
            var message = new EmailMessage
            {
                Sender = sender,
                Recipient = recipient,
                Subject = subject,
                Body = EncryptBody(body)
            };

            Console.WriteLine("Sending email");
            Console.WriteLine($"From {message.Sender}");
            Console.WriteLine($"To {message.Recipient}");
            Console.WriteLine($"Subject {message.Subject}");
            Console.WriteLine($"Body {message.Body}");
        }

        private string EncryptBody(string body) 
        {
            if (string.IsNullOrWhiteSpace(body))
            {
                throw new ArgumentException("Message body cannot be null or empty");
            }
            string encryptedBody = _securerHelper.Secure(body);
            return encryptedBody;

        }

    }
}
