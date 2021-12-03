using Lect8V2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lect8V2.Services
{
    public class MockAccountService : IAccountService
    {
        public Task<UserDetail> GetUserDetailAsync()
        {
            return Task.FromResult(new UserDetail()
            {
                Id = 0,
                Name = "tealdskjlaskdjlaksjdllakdsjlsakjst"
            });
        }

        public Task<bool> Login(string username, string password)
        {
            return Task.FromResult(true);
        }
    }
}
