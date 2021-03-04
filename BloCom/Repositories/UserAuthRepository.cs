using BloCom.Entities;
using BloCom.Resources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Text;
using BloCom.DataContext;

namespace BloCom.Repositories
{
    public class UserAuthRepository : IUserAuthRepository
    {
        private readonly DatabaseContext _context;

        public UserAuthRepository(DatabaseContext context)
        {
            _context = context;
        }
        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<int>> SignUp(User user, string password)
        {
            ServiceResponse<int> serviceResponse = new ServiceResponse<int>();
            if(await UserExists(user.UserName))
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "User Already Exists";
                return serviceResponse;
            }
            CreatePassswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            await _context.AddAsync(user);
            await _context.SaveChangesAsync();
            serviceResponse.Data = user.Id;
            return serviceResponse;
        }

        public async Task<bool> UserExists(string username)
        {
            if(await _context.Users.AnyAsync( c => c.UserName.ToLower() == username.ToLower()))
            {
                return true;
            }
            return false;
        }

        private void CreatePassswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using( var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
