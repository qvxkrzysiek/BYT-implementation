using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacjaBYT.Models
{
    public class Rezerwacja
    {
        public DateTime data { get; set; }
        public TimeOnly godzina { get; set; }
        public int liczbaMiejsc { get; set; }
        public virtual Klient klient { get; set; } = null!;
        public virtual StolikRezerwacja zarezerwowanyStolik { get; set; } = null!;

        public Rezerwacja ZlozenieRezerwacji() { return new Rezerwacja(); }
    }
}
