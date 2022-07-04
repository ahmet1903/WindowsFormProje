using KatmanlıMimariDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanlıMimariDataBussiness.İnterface
{
    public interface ISiparisManager
    {
        List<Siparis> HepsiniGetir();
        void Ekle(Siparis entity);
        void Sil(int id);
        void Guncelle(Siparis entity);
        Siparis IdyeGoreGetir(int id);
    }
}
