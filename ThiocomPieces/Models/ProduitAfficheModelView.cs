using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ThiocomPieces.Models
{
    public class ProduitAfficheModelView
    {
        public int ProduitId { get; set; }
        [DisplayName("Nom du produit")]
        [ReadOnly(true)]
        public string Nom { get; set; }


        [DisplayName("Référence du produit")]
        [ReadOnly(true)]
        public string Reference { get; set; }


        [DisplayName("Prix du produit")]
        [ReadOnly(true)]
        public double prix { get; set; }
    }
}