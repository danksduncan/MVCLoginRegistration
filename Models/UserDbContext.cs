using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCLoginRegistration.Models
{
    public class UserDbContext : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }
    }
}