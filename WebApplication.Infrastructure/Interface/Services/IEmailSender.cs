using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Infrastructure.Interface.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);

        Task SendEmailGridAsync(string email, string subject, string message);

    }
}
