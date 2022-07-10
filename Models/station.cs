using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace railway.Models
{
    public class station
    {
        [Key]
        public int id { get; set; }
        public string stationName { get; set; }
    }
}
