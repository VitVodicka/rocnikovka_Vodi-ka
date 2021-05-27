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

        public DateTime? Datum { get; set; }

        public string Importance { get; set; }

        public events(string name, DateTime? datum, string importance)
        {
            Name = name;
            Datum = datum;
            Importance = importance;
        }
    }
}
