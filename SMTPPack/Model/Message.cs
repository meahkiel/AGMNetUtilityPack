using MimeKit;

namespace SMTPPack.Model
{
    public class Message
    {
        public Message(IEnumerable<string> to, string subject, string content)
        {
            To = new List<MailboxAddress>();

            foreach (var item in to)
            {
                To.Add(new MailboxAddress("Recepient", item));
            }

            Subject = subject;
            Content = content;
        }

        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }


    }
}
