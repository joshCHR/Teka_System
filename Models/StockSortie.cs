using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teka_system.Models
{
    class StockSortie
    {
        public int IdStockSortie { get; set; }
        public string CodeStockSortie { get; set; }
        public string RefVente { get; set; }
        public string Statut { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
    }
}
