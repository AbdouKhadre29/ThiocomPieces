using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Thiocom.Entities;

namespace Thiocom.Entities
{
    public class Utilisateur
    {
        public int UtilisateurId { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(100)]
        public string Email { get; set; }
        public string Telephone { get; set; }

        [Required]
        public string MoDePasse { get; set; }


        public int RoleId { get; set; }
        public ICollection<Adresse> Adresses { get; set; }

    }

 
}