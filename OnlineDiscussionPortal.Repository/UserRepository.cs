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
        public  List<Account> accountList = new List<Account>();

        public UserRepository()
        {
            accountList.Add(new Account("Pragadishvari", "Pragadishvarik2020@srishakthi.ac.in", "04/09/1998", 9876543210, "Female", "59,Rose Garden,Ooty", "Indian"));
        }
        public IEnumerable<Account> GetUserDetail()
        {
            return accountList;
        }
        public void UpdateDetail(Account account)
        {
            foreach (Account value in accountList)
            {
                if (value.MailId == account.MailId)
                {
                    value.UserName = account.UserName;
                    value.Password = account.Password;
                    value.Name = account.Name;
                    value.Address = account.Address;
                }
            }
        }

    }
}
