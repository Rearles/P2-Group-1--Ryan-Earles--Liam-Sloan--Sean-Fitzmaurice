﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2_TCG.Models
{
    public class CreatedUser
    {
        public string username { get; set; }
        public string password { get; set; }

        public CreatedUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
