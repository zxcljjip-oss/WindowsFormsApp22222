using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.UsersClasses
{
    internal class InfoEmailSending
    {   
            public InfoEmailSending(
                string smtpClientAddress,
                StringPair emailAddressFrom,
                string emailPassword,
                StringPair emailAddressTo,
                string subject,
                string body)
            {
                SmtpClientAddress = string.IsNullOrWhiteSpace(smtpClientAddress)
                    ? throw new ArgumentException("Адрес SMTP клиента не может быть пустым", nameof(smtpClientAddress))
                    : smtpClientAddress;

                EmailAddressFrom = emailAddressFrom ?? throw new ArgumentNullException(nameof(emailAddressFrom));

                EmailPassword = string.IsNullOrWhiteSpace(emailPassword)
                    ? throw new ArgumentException("Пароль email не может быть пустым", nameof(emailPassword))
                    : emailPassword;

                EmailAddressTo = emailAddressTo ?? throw new ArgumentNullException(nameof(emailAddressTo));
                Subject = subject ?? throw new ArgumentNullException(nameof(subject));
                Body = body ?? throw new ArgumentNullException(nameof(body));
            }

            public string SmtpClientAddress { get; }
            public StringPair EmailAddressFrom { get; }
            public string EmailPassword { get; }
            public StringPair EmailAddressTo { get; }
            public string Subject { get; }
            public string Body { get; }
        
    }


}
