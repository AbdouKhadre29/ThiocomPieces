using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThiocomPieces.Models
{
    public class ProduitAjoutModelView
    {
        [DisplayName("Nom du produit")]
        [Required(ErrorMessage ="Champ requis")]
        [MaxLength(140,ErrorMessage = "Nombre de caractères max 140")]
        public string Nom { get; set; }

        [DisplayName("Référence du produit")]
        [Required(ErrorMessage = "Champ requis")]
        [MaxLength(140, ErrorMessage = "Nombre de caractères max 140")]
        public string Reference { get; set; }

        [DisplayName("Prix du produit")]
        [Required(ErrorMessage = "Champ requis")]
        public double prix { get; set; }

        [DisplayName("Description du produit")]
        [MaxLength(140, ErrorMessage = "Nombre de caractères max 140")]
        public string Description { get; set; }

        [DisplayName("Date de référence")]
        [Required(ErrorMessage = "Champ requis")]
        [MaxLength(140, ErrorMessage = "Nombre de caractères max 140")]

        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}", ApplyFormatInEditMode =true)]
        [DataType(DataType.Date)]
        public string DateReference { get; set; }

        [DisplayName("Photo du produit")]
        [Required(ErrorMessage = "Champ requis")]
        public HttpPostedFileBase Pixels { get; set; }
    }
}