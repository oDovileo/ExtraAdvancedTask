using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedTask
{
    class CompanyInfo
    {
        public string CompanyName { get; set; }

        public string CathPhrase { get; set; }

        public string Bs { get; set; }

        public CompanyInfo(string companyName, string cathPhrase, string bs)
        {
            CompanyName = companyName;
            CathPhrase = cathPhrase;
            Bs = bs;
        }
    }
}
