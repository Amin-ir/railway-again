using railway.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace railway.Models
{
    public class passenger
    {
        [Key]
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public DateTime birth { get; set; }
        public string father { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public sx jnst { get; set; }
    }
}
