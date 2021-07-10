﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedTask
{
    public class  AddressInfo
    {
        public string Street { get; set; }

        public string Suite { get; set; }

        public string City { get; set; }

        public string Zipcode { get; set; }

        public AddressInfo(string street, string suite, string city, string zipcode)
        {
            Street = street;
            Suite = suite;
            City = city;
            Zipcode = zipcode;
        }
    }
}
