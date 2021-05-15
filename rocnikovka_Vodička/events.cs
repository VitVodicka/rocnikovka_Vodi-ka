using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocnikovka_Vodička
{
    class events : login_details
    {
        public string Name { get; set; }
        public string MoreInfo { get; set; }

        public DateTime? Datum { get; set; }

        public string Importance { get; set; }

        public events(string name, string moreInfo, DateTime? datum, string importance)
        {
            Name = name;
            MoreInfo = moreInfo;
            Datum = datum;
            Importance = importance;
        }
    }
}
