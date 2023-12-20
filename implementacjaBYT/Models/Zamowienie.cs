using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacjaBYT.Models
{
    public class Zamowienie
    {
        public double cena { get; set; }
        public string metodaPlatnosci { get; set; }
        public Zamowienie ZlozenieZamowienia() { return new Zamowienie(); }
    }
}
