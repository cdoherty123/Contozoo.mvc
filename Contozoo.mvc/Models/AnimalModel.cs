using System;
using System.Linq;
using System.Threading.Tasks;

namespace Contozoo.mvc.Models

{
    public class AnimalModel
    {
        public int AnimalId { get; set; }
        public int CAI { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime LunchHour { get; set; }
        public string Notes { get; set; }
    }
}
