﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Project1.Classes
{
    public class Address
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
