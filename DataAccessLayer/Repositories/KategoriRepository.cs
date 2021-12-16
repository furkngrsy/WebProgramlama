using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class KategoriRepository : IKategoriDal
    {
        Context ct = new Context();

        public void Delete(Kategori g)
        {
            throw new NotImplementedException();
        }

        public Kategori idGetir(int id)
        {
            return ct.Kategoris.Find(id);
        }

        public void Insert(Kategori g)
        {
            throw new NotImplementedException();
        }

        public void kategoriEkle(Kategori kategori)
        {
            ct.Add(kategori);
            ct.SaveChanges();
        }

        public void kategoriGuncelle(Kategori kategori)
        {
            ct.Update(kategori);
            ct.SaveChanges();
        }

        public List<Kategori> KategorileriListele()
        {
            return ct.Kategoris.ToList();
        }

        public void kategoriSil(Kategori kategori)
        {
            ct.Remove(kategori);
            ct.SaveChanges();
        }

        public List<Kategori> Listele()
        {
            throw new NotImplementedException();
        }

        public void Update(Kategori g)
        {
            throw new NotImplementedException();
        }
    }
}
