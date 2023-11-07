using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teka_system.Models
{
    class StockEntree
    {
        public int IdStockEntree { get; set; }
        public string CodeStockEntree { get; set; }
        public string RefApprovisionnement { get; set; }
        public string RefRetour { get; set; }
        public string Statut { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
    }
}
