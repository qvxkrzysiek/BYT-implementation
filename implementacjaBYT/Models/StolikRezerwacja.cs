using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacjaBYT.Models
{
    public class StolikRezerwacja
    {
        public virtual Stolik stolik { get; set; } = null!;
        public virtual Rezerwacja rezerwacja { get; set; } = null!;
    }
}
