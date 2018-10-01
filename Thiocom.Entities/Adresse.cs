using System.ComponentModel.DataAnnotations;

namespace Thiocom.Entities
{
    public class Adresse
    {
        public int AdresseId { get; set; }
        [Required]
        public string Pays { get; set; }
        [Required]
        public string Ville { get; set; }
      
        public int CodePostal { get; set; }
        public string NomDeRue { get; set; }
        public string NumerosDeRue { get; set; }

        public int UtilisateurId { get; set; }
    }
}