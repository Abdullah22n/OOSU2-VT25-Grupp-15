using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class TrainingSession
    {
        public int SessionId { get; set; }
        public string Namn { get; set; }
        public string ActivityName { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Location { get; set; }
        public int TrainerId { get; set; }
    }
}
