using KatmanlıMimariDataAccess.Context;
using KatmanlıMimariDataAccess.Entity;
using KatmanlıMimariDataBussiness.İnterface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanlıMimariDataBussiness.Manager
{
    public class UrunManager : IUrunManager
    {
        public void Ekle(Urun entity)
        {
            using (MagazaYonetimiDbContext db = new MagazaYonetimiDbContext())
            {
                db.Urunler.Add(entity);
                db.SaveChanges();
            }
        }

        public void Guncelle(Urun entity)
        {
            using (MagazaYonetimiDbContext db = new MagazaYonetimiDbContext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Urun> HepsiniGetir()
        {
            using (MagazaYonetimiDbContext db = new MagazaYonetimiDbContext())
            {
                return db.Urunler.ToList();
            }
        }

        public List<int> IdleriGetir()
        {
            using (MagazaYonetimiDbContext db = new MagazaYonetimiDbContext())
            {
                List<Urun> urunler = HepsiniGetir();
                List<int> idler = new List<int>();
                foreach (var item in urunler)
                {
                    idler.Add(item.ID);
                }
                return idler;
            }
        }

        public Urun IdyeGoreUrunGetir(int id)
        {
            using (MagazaYonetimiDbContext db = new MagazaYonetimiDbContext())
            {
                var urun = db.Urunler.Find(id);
                return urun;
            }
        }

        public void Sil(int id)
        {
            using (MagazaYonetimiDbContext db = new MagazaYonetimiDbContext())
            {
                var silinecekEleman = db.Urunler.Find(id);
                db.Urunler.Remove(silinecekEleman);
                db.SaveChanges();
            }
        }
    }
}
