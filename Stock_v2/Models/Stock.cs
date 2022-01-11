using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_v2.Models
{
    public class Stock
    {
        
        public int Id { get; set; }
        public string Walor { get; set; }
        public float Kurs { get; set; }

    }
}
