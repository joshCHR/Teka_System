﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teka_system.Models
{
    class Retours
    {
        public int IdRetour { get; set; }
        public string RefVente { get; set; }
        public double Quantite { get; set; }
        public string Statut { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
        public string Created_by { get; set; }
        public string Updated_by { get; set; }
    }
}
