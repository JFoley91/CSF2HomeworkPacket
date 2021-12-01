using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        //frugal / fields
        private string _username;
        private string _password;


        //people / properties
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        //collect / constructors (ctors)
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Login() { }
        //money / methods
        public override string ToString()
        {
            return string.Format("Your Username is: {0}\n" +
                                 "Your Password is: {1}\n",
                                 Username,
                                 Password);
        }
    }
}
