using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay.Models
{
    public class EmailMessageBuilder
    {
        private MailMessage _emailMessage;

        public EmailMessageBuilder()
        {
            _emailMessage = new MailMessage();
        }

        public EmailMessageBuilder WithSubject(string subject)
        {
            _emailMessage.Subject = subject;
            return this;
        }

        public EmailMessageBuilder WithBody(string body)
        {
            _emailMessage.Body = body;
            return this;
        }

        public EmailMessageBuilder From(string senderEmail, string senderName)
        {
            _emailMessage.From = new MailAddress(senderEmail, senderName);
            return this;
        }

        public EmailMessageBuilder To(string recipientEmail, string recipientName)
        {
            _emailMessage.To.Add(new MailAddress(recipientEmail, recipientName));
            return this;
        }

        public MailMessage Build()
        {
            return _emailMessage;
        }
    }
}
