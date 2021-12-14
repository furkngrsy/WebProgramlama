using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Takviyeler
    {
        [Key]
        public int TakviyeID { get; set; }
        public string  TakviyeAd { get; set; }
        public int TakviyeFiyat { get; set; }
        public string  TakviyeKucukFoto { get; set; }
        public string TakviyeFoto { get; set; }
        public string Marka { get; set; }
        public string TakviyeAroma { get; set; }
        public int TakviyeAdet { get; set; }
        public bool TakviyeDurum { get; set; }


    }
}
