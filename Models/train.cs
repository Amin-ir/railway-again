using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace railway.Models
{
    public class train
    {
        [Key]
        public int id { get; set; }
        public int degree { get; set; }
        public int wagon { get; set; }
        public int coupPerWagon { get; set; }
        public int searPerCoup { get; set; }
        public trainType trType { get; set; }
        //Virtual Attribute
        public int fullCap { get; set; }
        //References
        public int orgID { get; set; }

    }
}
