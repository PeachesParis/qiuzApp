using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Questions
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string email { get; set; }

        public Questions(string userName, string passWord, string Email) {

            this.Username = userName;
            this.Password = passWord;
            this.email = Email;
        }
        public Questions(string userName, string passWord)
        {
            this.Username = userName;
            this.Password = passWord;
        }

    }
}
