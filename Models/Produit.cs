using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teka_system.Models
{
    class Produit
    {
        public int IdProduit { get; set; }
        public string CodeProduit { get; set; }
        public string DesignationProduit { get; set; }
        public string DescriptionProduit { get; set; }
        public int RefCategorie { get; set; }
        public SqlMoney PrixUnitaire { get; set; }
        public string Statut { get; set; }

    }
}
