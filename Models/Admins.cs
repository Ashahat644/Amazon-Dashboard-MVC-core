﻿using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Admin.Models
{
    public partial class Admins : BaseClass
    {
        public Admins()
        {
            Contacts = new HashSet<Contact>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
