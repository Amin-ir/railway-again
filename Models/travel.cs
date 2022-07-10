using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace railway.Models
{
    public class travel
    {
        [Key]
        public int id { get; set; }
        public DateTime startTime { get; set; }
        public DateTime arrivalTime { get; set; }
        public int basePrice { get; set; }
        //References
        public int startCityID { get; set; }
        public int arrivalCityID { get; set; }
        public int trainID { get; set; }
        //virtual attribute
        public int remainingCap { get; set; }

    }
}
