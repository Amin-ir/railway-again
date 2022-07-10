using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace railway.Models
{
    public class financeTransactions
    {
        [Key]
        public int id { get; set; }
        public int price { get; set; }
        //References
        public int passengerID { get; set; }
        //public List<passenger> passengers { get; set; }
    }
}
