using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiocomPieces.DTO
{
   public class AdresseDTO
    {
        public int AdresseId { get; set; }

    }

    public class AdresseInfos:AdresseDTO
    {
        public string Pays { get; set; }
        public string Ville { get; set; }
        public int CodePostal { get; set; }
        public string NomDeRue { get; set; }
        public string NumerosDeRue { get; set; }
    }

    public class AdresseAjout
    {
        public string Pays { get; set; }
        public string Ville { get; set; }
        public int CodePostal { get; set; }
        public string NomDeRue { get; set; }
        public string NumerosDeRue { get; set; }
        public int UtilisateurId { get; set; }
    }
}
