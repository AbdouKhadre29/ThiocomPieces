using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiocomPieces.DTO
{
    public class ProduitDTO
    {
        public int ProduitID { get; set; }
        public string Reference { get; set; }
    }
    public class ProduitInfos : ProduitDTO
    {
        public string Nom { get; set; }
        public double? Prix { get; set; }
    }

    public class ProduitDetails: ProduitInfos
    {
        public string Description { get; set; }
        public DateTime DateReference { get; set; }
    }

    public class ProduitAjout
    {
        public string Nom { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public double? Prix { get; set; }
        public byte[] pixels { get; set; }
        public DateTime DateReference { get; set; }
       
    }
}
