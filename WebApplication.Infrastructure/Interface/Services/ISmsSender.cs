using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Infrastructure.Interface.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);

    }
}
