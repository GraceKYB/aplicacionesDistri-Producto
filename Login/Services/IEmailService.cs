using System.Threading.Tasks;

namespace Login.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }

}
