using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace railway.Models
{
    public class meal
    {
        [Key]
        public int id { get; set; }
        public string mealTitle { get; set; }
        public int mealPrice { get; set; }
    }
}
