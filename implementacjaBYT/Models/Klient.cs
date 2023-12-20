using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacjaBYT.Models
{
    public class Klient : Osoba
    {
        public virtual ICollection<Ocena> oceny { get; set; }
    }
}
