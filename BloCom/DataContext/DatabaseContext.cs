using BloCom.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloCom.DataContext
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
