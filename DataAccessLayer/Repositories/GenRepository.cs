using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenRepository<G> : IGenericDal<G> where G : class
    {
        public void Delete(G g)
        {
            using var ct = new Context();
            ct.Remove(g);
            ct.SaveChanges();
        }

        public G idGetir(int id)
        {
            using var ct = new Context();
            return ct.Set<G>().Find(id);
        }

        public void Insert(G g)
        {
            using var ct = new Context();
            ct.Add(g);
            ct.SaveChanges();
        }

        public List<G> Listele()
        {
            using var ct = new Context();
            return ct.Set<G>().ToList();
        }

        public void Update(G g)
        {
            using var ct = new Context();
            ct.Update(g);
            ct.SaveChanges();
        }
    }
}
