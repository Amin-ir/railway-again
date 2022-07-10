using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace railway.Models
{
    public class ticket
    {
        public int wagNum { get; set; }
        public int coupNum { get; set; }
        public int seatNum { get; set; }
        public bool mealReq { get; set; }
        //Virtual Attribute
        public int finalPrice { get; set; }
        //References
        public int passengerID { get; set; }
        public int travelID { get; set; }
    }
}
