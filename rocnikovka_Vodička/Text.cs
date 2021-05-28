using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocnikovka_Vodička
{
    class Text
    {
        public string Name { get; set; }
        public DateTime? Datum { get; set; }

        public Text(string name, DateTime? datum)
        {
            Name = name;
            Datum = datum;
        }
    }
}
