﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountService.Models
{
    public class Accounts
    {
         public int ID { get; set; }
        public string AccountType { get; set; }

        public string  Name { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
        public string PAN { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
    }
}
