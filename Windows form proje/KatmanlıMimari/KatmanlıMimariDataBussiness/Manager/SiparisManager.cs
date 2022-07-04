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
    public class SiparisManager : ISiparisManager
    {
        public void Ekle(Siparis entity)
        {
            using (MagazaYonetimiDbContext db = new MagazaYonetimiDbContext())
            {
                db.Siparisler.Add(entity);
                db.SaveChanges();
            }
        }

        public void Guncelle(Siparis entity)
        {
            using (MagazaYonetimiDbContext db = new MagazaYonetimiDbContext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Siparis> HepsiniGetir()
        {
            using (MagazaYonetimiDbContext db = new MagazaYonetimiDbContext())
            {
                List<Siparis> tumSiparisler = db.Siparisler.ToList();
                return tumSiparisler;
            }
        }

        public Siparis IdyeGoreGetir(int id)
        {
            using (MagazaYonetimiDbContext db = new MagazaYonetimiDbContext())
            {
                return db.Siparisler.Where(x => x.ID == id).FirstOrDefault();
            }
        }

        public void Sil(int id)
        {
            using (MagazaYonetimiDbContext db = new MagazaYonetimiDbContext())
            {
                var silinecekEleman = db.Siparisler.Find(id);
                db.Siparisler.Remove(silinecekEleman);
                db.SaveChanges();
            }
        }
    }
}
