using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanlıMimariDataAccess.Entity
{
   public class Siparis:BaseEntity
    {
        public string MusteriAdi { get; set; }
        public string Adres { get; set; }
        public double ToplamTutar { get; set; }
        public Urun Urun { get; set; }
    }
}
