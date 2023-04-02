using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Project
{
    internal class acc
    {
        public String username;
        public String password;
        public String balance;
        public String phone;
        public String dob;
        public int gender;
        public String email;
        public String type;

        public String getType
        {
            get { return type; }
            set { type = value; }
        }

        public String getEmail
        {
            get { return email; }
            set { email = value; }
        }

        public int getGender { 
            get { return gender; }
            set { gender = value; }
        }

        public string getDOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public string getUsername
        {
            get { return username; }
            set { username = value; }
        }

        public string getPassword
        {
            get { return password; }
            set { password = value; }
        }

        public String getBalance
        {
            get { return balance; }
            set { balance = value; }
        }

        public String getPhone {
            get { return phone; }
            set { phone = value; }
        }
        private acc() { }
        public static readonly acc Instance = new acc();

    }
}
