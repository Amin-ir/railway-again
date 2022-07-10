using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace railway.Models
{
    public class travel_station
    {
        public DateTime entrance { get; set; }
        public DateTime exit { get; set; }
        //References
        public int travelID { get; set; }
        public int stationID { get; set; }
    }
}
