using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineDiscussionPortal.Entity
{
    public class Account
    {
        
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string MailId { get; set; }
        public string DateOfBirth { get; set; }
        [Required]
        public long MobileNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        [Required]
        public string Nationality { get; set; }
        public Account(string userName, string password, string name, string mailId, string dateOfBirth, long mobileNumber, string gender, string address, string nationality)
        {
            this.UserName = userName;
            this.Password = password;
            this.Name = name;
            this.MailId = mailId;
            this.DateOfBirth = dateOfBirth;
            this.MobileNumber = mobileNumber;
            this.Gender = gender;
            this.Address = address;
            this.Nationality = nationality;
        }
        public Account()
        {

        }
    }
}
