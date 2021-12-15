using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKategoriServis
    {
        void kategoriEkle(Kategori kategori);
        void kategoriSil(Kategori kategori);
        void kategoriGuncelle(Kategori kategori);
        List<Kategori> listeGetir();
        Kategori idGetir(int id);

    }
}
