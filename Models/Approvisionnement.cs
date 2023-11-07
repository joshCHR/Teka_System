using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teka_system.Models
{
    class Approvisionnement
    {
        public int IdApprovisionnement { get; set; }
        public string CodeApprovisionnement { get; set; }
        public string RefFourniture { get; set; }
        public string RefFournisseur { get; set; }
        public DateTime DateApprovisionnement { get; set; }
        public double Quantite { get; set; }
        public string DesicriptionFourniture { get; set; }
        public SqlMoney PrixAchatUnitaire { get; set; }
        public SqlMoney PrixVenteUnitaire { get; set; }
        public string Status { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
        public string Created_by { get; set; }
        public string Updated_by { get; set; }
    }
}
