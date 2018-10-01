using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiocomPieces.DTO
{
    public class UtilisateurDTO
    {
        public int UtilisateurId { get; set; }
        public string Email { get; set; }
    }

    public class UtilisateurInfos:UtilisateurDTO
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
    public class UtilisateurAjout
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public string Telephone { get; set; }
        public int RoleId { get; set; }

    }
}
