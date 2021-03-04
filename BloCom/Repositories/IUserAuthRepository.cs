using BloCom.Entities;
using BloCom.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloCom.Repositories
{
    interface IUserAuthRepository
    {
        Task<ServiceResponse<int>> SignUp(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);

    }
}
