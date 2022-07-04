using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanlıMimariDataAccess.Entity
{
    public class Urun:BaseEntity
    {
        public string Marka { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public int Adet { get; set; }
    }
}
