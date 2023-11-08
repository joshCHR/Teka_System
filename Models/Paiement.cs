using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teka_system.Models
{
    class Paiement
    {
        public int IdPaiement { get; set; }
        public string CodePaiement { get; set; }
        public DateTime DatePaiement { get; set; }
        public string RefVente { get; set; }
        public SqlMoney SommeDue { get; set; }
        public SqlMoney SommePayee { get; set; }
        public SqlMoney ResteAPayer { get; set; }
        public string Statut { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
        public string Created_by { get; set; }
        public string Updated_by { get; set; }
    }
}
