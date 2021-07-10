using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedTask
{
    class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }
                
        public string UserName { get; set; }

        public string Email { get; set; }

        public AddressInfo Address { get; set; }

        public GeoInfo Geo { get; set; }

        public string Phone { get; set; }
    
        public string Website { get; set; }

        public CompanyInfo Company { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} \nUserName: {1} \nEmail: {2} \nAddress: {3} \nGeo: {4} \nPhone: {5} \nWebsite: {6} Company: {7}", Name, UserName, Email, Address, Geo, Phone, Website, Company) ;
        }
    }
}
