using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiocom.Entities
{

    public class Produit
    {
        public int ProduitID { get; set; }

        [Required]
        [MaxLength(140)]
        public string Reference { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public double? Prix { get; set; }
      
        public string Description { get; set; }

        [Required]
        public DateTime DateReference { get; set; }

        [Required]
        public byte[] pixels { get; set; }

    }

}
