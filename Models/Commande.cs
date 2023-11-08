using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teka_system.Models
{
    class Commande
    {
        public int IdCommande { get; set; }
        public string CodeCommande { get; set; }
        public string RefFourniture { get; set; }
        public string RefFournisseur { get; set; }
        public double Quantite { get; set; }
        public string Statut { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }

    }
}
