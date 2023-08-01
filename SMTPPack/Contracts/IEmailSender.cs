using SMTPPack.Model;

namespace SMTPPack.Contracts
{
    public interface IEmailSender
    {
        Task SendEmail(Message message);
    }
}
