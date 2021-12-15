using BusinessLayer.Abstract;
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
        EfKategoriRepository efKategoriRepository;

        public KategoriManager()
        {
            efKategoriRepository = new EfKategoriRepository();
        }
        public Kategori idGetir(int id)
        {
            return efKategoriRepository.idGetir(id);
        }

        public void kategoriEkle(Kategori kategori)
        {
            efKategoriRepository.Insert(kategori);

        }

        public void kategoriGuncelle(Kategori kategori)
        {
            efKategoriRepository.Update(kategori);
        }

        public void kategoriSil(Kategori kategori)
        {
            efKategoriRepository.Delete(kategori);
        }

        public List<Kategori> listeGetir()
        {
            return efKategoriRepository.Listele();
        }
    }
}
