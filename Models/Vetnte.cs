using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teka_system.Models
{
    class Vetnte
    {
        public int IdVente { get; set; }
        public string CodeVente { get; set; }
        public DateTime DateVente { get; set; }
        public string RefClient { get; set; }
        public string RefApprovisionnement { get; set; }
        public double Quantite { get; set; }
        public SqlMoney FakePrixVente { get; set; }
        public string RefModePaiement { get; set; }
        public string Statut { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
        public string Created_by { get; set; }
        public string Updated_by { get; set; }
    }
}
