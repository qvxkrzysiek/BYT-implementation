using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacjaBYT.Models
{
    public class Ocena
    {
        [Range(0, 10)]
        public int ocena { get; set; }
        public string opis { get; set; }
        public virtual Klient Klient { get; set; } = null!;
        public Ocena WystawienieOceny() { return new Ocena(); }
    }
}
