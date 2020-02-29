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
        [RegularExpression(@"[a-zA-Z0-9]*$" , ErrorMessage ="UserName Should not contain any special characters")]
        public string UserName { get; set; }
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$",ErrorMessage =(@"At least one lower case letter,
                              At least one upper case letter,
                             At least special character,
                            At least one number,
                           At least 8 characters length"))]
        [Required]
        public string Password { get; set; }
        [Required]
        [RegularExpression(@"[a-zA-Z]*$", ErrorMessage = "Please Enter a valid Name")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Please enter a valid email address")]
        public string MailId { get; set; }
        public string DateOfBirth { get; set; }
        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public long MobileNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
       
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
        public Account(string name, string mailId, string dateOfBirth, long mobileNumber, string gender, string address, string nationality)
        {
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
