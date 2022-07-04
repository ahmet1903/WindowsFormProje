using KatmanlıMimariDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanlıMimariDataBussiness.İnterface
{
    public interface IUrunManager
    {
        List<Urun> HepsiniGetir();
        void Ekle(Urun entity);
        void Sil(int id);
        void Guncelle(Urun entity);
        List<int> IdleriGetir();
        Urun IdyeGoreUrunGetir(int id);
    }
}
