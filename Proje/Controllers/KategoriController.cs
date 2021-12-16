using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Controllers
{
    public class KategoriController : Controller
    {
        KategoriManager km = new KategoriManager(new EfKategoriRepository());
        public IActionResult Index()
        {
            var degerler = km.listeGetir();
            return View(degerler);
        }
    }
}
