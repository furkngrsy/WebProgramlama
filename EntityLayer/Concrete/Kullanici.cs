using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
     public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciMail { get; set; }
        public string KullaniciSifre { get; set; }
        public bool KullaniciDurum { get; set; }

    }
}
