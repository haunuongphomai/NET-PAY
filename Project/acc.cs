﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class acc
    {
        public String username;
        public String password;
        public String balance;
        public String phone;

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
