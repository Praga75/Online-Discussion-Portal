using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineDiscussionPortal.Entity;

namespace OnlineDiscussionPortal.Repository
{
    public class UserRepository
    {
        public static List<Account> accountList = new List<Account>();

        static UserRepository()
        {
            accountList.Add(new Account("Pragadishvari", "Pragadishvarik2020@srishakthi.ac.in", "04/09/1998", 9876543210, "Female", "59,Rose Garden,Ooty", "Indian"));
        }
        public IEnumerable<Account> GetUserDetail()
        {
            return accountList;
        }
        
    }
}
