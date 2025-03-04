using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMS
{
    public class Member      //class for storing properties of a member
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredDay { get; set; }



        public Member()
        {
            RegisteredDay = DateTime.Today;
        }

        public Member(string userId, string userName, string email,DateTime regday=default(DateTime))
        {
            UserId = userId;
            UserName = userName;
            Email = email;
            RegisteredDay = regday == default(DateTime) ? DateTime.Now : regday;
        }   
    }

    
}
