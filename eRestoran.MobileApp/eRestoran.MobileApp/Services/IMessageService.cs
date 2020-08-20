using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.MobileApp.Services
{
    public interface IMessageService
    {
        Task ShowAsync(string message);
    }
}
