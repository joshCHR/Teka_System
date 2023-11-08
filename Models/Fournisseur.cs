using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teka_system.Models
{
    class Fournisseur
    {
        public int IdFournisseur { get; set; }
        public string CodeFournisseur { get; set; }
        public string NomFournusseur { get; set; }
        public string ContactFournisseur { get; set; }
        public string Statut { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
    }
}
