using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacjaBYT.Models
{
    public enum StatusStolika { Zarezerwowany, Wolny}
    public class Stolik
    {
        public int maxIloscMiejsc { get; set; }
        public int numerStolika { get; set; }
        public StatusStolika statusStolika { get; set; }

        public virtual ICollection<StolikRezerwacja> rezerwacjeStolika{ get; set; } = null!;
    }
}
