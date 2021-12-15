using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<G> where G: class
    {
        void Insert(G g);
        void Delete(G g);
        void Update(G g);
        List<G> Listele();
        G idGetir(int id);

    }
}
