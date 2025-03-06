using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Träningspass
    {
        public int PassId { get; set; }
        public string AktivitetsNamn { get; set; }
        public DateTime Datum { get; set; }
        public string Plats { get; set; }
        public TimeSpan Tid { get; set; }
        public int TränarId { get; set; }
    }
}
