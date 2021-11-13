using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_v2.Models.ViewModels
{
    public class StocksViewModel
    {
        public string Walor { get; set; }
        public float Kurs { get; set; }       
        public float Zmiana { get; set; }
    }
}
