using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocnikovka_Vodička
{
    public class events : login_details
    {
        public string Name { get; set; }//definované proměnné

        public DateTime? Datum { get; set; }

        public string Importance { get; set; }

        public string ImportanceToText//přidělí do proměnné datum a text
        {
            get
            {
                return Datum.Value.Day + "." + Datum.Value.Month + "." + Datum.Value.Year + " " + Name;
            }
        }

        public events(string name, DateTime? datum, string importance)
        {
            Name = name;
            Datum = datum;
            Importance = importance;
        }
    }
}
