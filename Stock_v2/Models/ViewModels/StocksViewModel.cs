using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_v2.Models.ViewModels
{
    public class StocksViewModel
    {
        public int Id { get; set; }
        public string Walor { get; set; }
        public float Kurs { get; set; }       
        public float Zmiana { get; set; }
        public float CenaZakupu { get; set; }
        public int LiczbaAkcji { get; set; }
        public float Zysk { get; set; }
    }
}
