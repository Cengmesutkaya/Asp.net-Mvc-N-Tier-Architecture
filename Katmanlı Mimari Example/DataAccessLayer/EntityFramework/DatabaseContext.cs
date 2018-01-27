using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Student> student { get; set; }
        public DbSet<LoginUser> LoginUsers { get; set; }

    }
}
