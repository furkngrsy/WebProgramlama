using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
     public class Hakkinda
    {
        [Key]
        public int HakkindaID { get; set; }
        public string HakkindaDetay1 { get; set; }
        public string HakkindaDetay2 { get; set; }
        public string HakkindaFoto1 { get; set; }
        public string HakkindaFoto2 { get; set; }



    }
}
