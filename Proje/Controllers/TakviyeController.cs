using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Controllers
{
    public class TakviyeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
