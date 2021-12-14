﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    class Yorumlar
    {
        [Key]
        public int YorumID { get; set; }
        public string YorumKullanici { get; set; }
        public string YorumIcerik { get; set; }
        public DateTime YorumTarih { get; set; }
        public bool YorumDurum { get; set; }
    }
}