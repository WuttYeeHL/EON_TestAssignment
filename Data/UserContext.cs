using Eon_TestAssignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eon_TestAssignment.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public UserContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder model)
        {

        }
        public DbSet<User> users { get; set; }
       
    }
}
