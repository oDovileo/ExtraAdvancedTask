using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedTask
{
    class GeoInfo
    {
        public string Lat { get; set; }

        public string Lng { get; set; }

        public GeoInfo(string lat, string lng)
        {
            Lat = lat;
            Lng = lng;
        }
    }
}
