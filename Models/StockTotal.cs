using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teka_system.Models
{
    class StockTotal
    {
        public int IdStockTotal { get; set; }
        public string CodeStockTotal { get; set; }
        public string StockInitial { get; set; }
        public string RefSctockEntree { get; set; }
        public string RefStockSortie { get; set; }
        public string StockFinal { get; set; }
        public string Statut { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
    }
}
