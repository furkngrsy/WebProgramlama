using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KategoriManager : IKategoriServis
    {
        IKategoriDal _kategoriDal;
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public Kategori idGetir(int id)
        {
            return _kategoriDal.idGetir(id);
        }

        public void kategoriEkle(Kategori kategori)
        {
            _kategoriDal.Insert(kategori);

        }

        public void kategoriGuncelle(Kategori kategori)
        {
            _kategoriDal.Update(kategori);
        }

        public void kategoriSil(Kategori kategori)
        {
            _kategoriDal.Delete(kategori);
        }

        public List<Kategori> listeGetir()
        {
            return _kategoriDal.Listele();
        }
    }
}
