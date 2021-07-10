using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedTask
{
    class CompanyInfo
    {
        public string Name { get; set; }

        public string CatchPhrase { get; set; }

        public string Bs { get; set; }

        public CompanyInfo(string name, string catchPhrase, string bs)
        {
            Name = name;
            CatchPhrase = catchPhrase;
            Bs = bs;
        }
    }
}
