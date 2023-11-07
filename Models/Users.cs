using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teka_system.Models
{
    class Users
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Noms { get; set; }
        public string Contact { get; set; }
        public string Niveau { get; set; }
        public string Statut { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
        public string Created_by { get; set; }
        public string Updated_by { get; set; }
    }
}
