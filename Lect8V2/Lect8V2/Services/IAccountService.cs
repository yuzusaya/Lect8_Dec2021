using Lect8V2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lect8V2.Services
{
    public interface IAccountService
    {
        Task<bool> Login(string username, string password);
        Task<UserDetail> GetUserDetailAsync();
    }
}
