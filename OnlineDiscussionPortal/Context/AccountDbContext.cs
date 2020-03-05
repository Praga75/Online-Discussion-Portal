using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

using System.Data.Entity;
using OnlineDiscussionPortal.Entity;
namespace OnlineDiscussionPortal.Context
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext() : base("AccountDbContext")
        {

        }
        public DbSet<Account> accounts { get; set; }
    }
}