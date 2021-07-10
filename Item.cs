using Newtonsoft.Json;
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

        //[JsonProperty("address")]
        public AddressInfo Address { get; set; }            

        public string Phone { get; set; }
    
        public string Website { get; set; }

       // [JsonProperty("company")]
        public CompanyInfo Company { get; set; }

        public override string ToString()
        {
            //return string.Format("Name: {0} \nUserName: {1} \nEmail: {2} \nAddress: {3} \nGeo: {4} \nPhone: {5} \nWebsite: {6} \nCompany: {7}", Name, UserName, Email, Address, Geo, Phone, Website, Company) ;
            return string.Format($"Name: {Name} \nUserName: {UserName} \nEmail: {Email} \nAddress: {Address.Street}, {Address.Suite}, {Address.City}, {Address.Zipcode}, \nGeo: {Address.Geo.Lat}, {Address.Geo.Lng}, \nPhone: {Phone} \nWebsite: {Website} \nCompany: {Company.Name}, {Company.CatchPhrase}, {Company.Bs}.");
        }
    }
}
