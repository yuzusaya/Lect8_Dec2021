using Lect8V2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lect8V2.Services
{
    public class AccountService : IAccountService
    {
        public async Task<UserDetail> GetUserDetailAsync()
        {
            await Task.Delay(3000);//simulating retrieve data from db
            Random random = new Random();

            return new UserDetail()
            {
                Id = random.Next(0, 100),
                Name = "From api"
            };
        }

        public async Task<bool> Login(string username, string password)
        {
            await Task.Delay(3000);//simulating retrieve data from db
            return true;
        }
    }
}
