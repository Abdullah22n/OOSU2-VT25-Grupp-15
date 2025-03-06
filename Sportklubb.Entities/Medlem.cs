using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Medlem
    {
        public int MedlemId { get; set; }
        public string Namn { get; set; }
        public DateTime Födelsedatum { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public bool Betalstatus { get; set; }
        public int Poäng { get; set; }
    }

}
