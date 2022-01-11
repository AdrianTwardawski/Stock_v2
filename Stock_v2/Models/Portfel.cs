using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_v2.Models
{
    public class Portfel
    {
        [Key]
        public int Id { get; set; }
        public string Walor { get; set; }
        public float Kurs { get; set; }
        public float Zmiana { get; set; }
        public float CenaZakupu { get; set; }
        public int LiczbaAkcji { get; set; }
        public float Zysk { get; set; }
        public int WalorId { get; set; }
    
    }
}
