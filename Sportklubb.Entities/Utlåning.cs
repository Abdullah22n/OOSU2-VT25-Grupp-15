using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Utlåning
    {
        public int UtlåningId { get; set; }
        public int MedlemId { get; set; }
        public int Inventarienummer { get; set; }
        public DateTime Utlåningsdatum { get; set; }
        public DateTime? Återlämningsdatum { get; set; }
    }
}
