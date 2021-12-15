using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ITakviyelerDal
    {
        List<Takviyeler> TakviyeleriListele();
        void takviyeEkle(Takviyeler takviyeler);
        void takviyeSil(Takviyeler takviyeler);
        void takviyeGuncelle(Takviyeler takviyeler);
        Takviyeler idGetir(int id);
    }
}
