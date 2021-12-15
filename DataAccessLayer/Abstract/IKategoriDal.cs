using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IKategoriDal
    {
        List<Kategori> KategorileriListele();
        void kategoriEkle(Kategori kategori);
        void kategoriSil(Kategori kategori);
        void kategoriGuncelle(Kategori kategori);
        Kategori idGetir(int id);
    }
}
