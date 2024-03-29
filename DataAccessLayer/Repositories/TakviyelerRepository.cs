﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class TakviyelerRepository : ITakviyelerDal

    {
        public void Delete(Takviyeler g)
        {
            throw new NotImplementedException();
        }

        public Takviyeler idGetir(int id)
        {
            using var ct = new Context();
            return ct.Takviyelers.Find(id);
        }

        public void Insert(Takviyeler g)
        {
            throw new NotImplementedException();
        }

        public List<Takviyeler> Listele()
        {
            throw new NotImplementedException();
        }

        public void takviyeEkle(Takviyeler takviyeler)
        {
            using var ct = new Context();
            ct.Add(takviyeler);
            ct.SaveChanges();
        }

        public void takviyeGuncelle(Takviyeler takviyeler)
        {
            using var ct = new Context();
            ct.Update(takviyeler);
            ct.SaveChanges();
        }

        public List<Takviyeler> TakviyeleriListele()
        {
            using var ct = new Context();
            return ct.Takviyelers.ToList();
        }

        public void takviyeSil(Takviyeler takviyeler)
        {
            using var ct = new Context();
            ct.Remove(takviyeler);
            ct.SaveChanges();
        }

        public void Update(Takviyeler g)
        {
            throw new NotImplementedException();
        }
    }
}
