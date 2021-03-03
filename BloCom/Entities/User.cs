using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloCom.Entities
{
    public class User
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
