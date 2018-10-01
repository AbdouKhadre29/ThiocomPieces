using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thiocom.Entities;
using ThiocomPieces.DAL;
using ThiocomPieces.DTO;


namespace ThiocomPieces.BLL
{
    public class ProduitServices
    {
        private ThiocomPiecesDbContext ctx = new ThiocomPiecesDbContext();

       
        public int AjouterProduit(ProduitAjout produitAjoutDTO)
        {
            Produit produitEntite = ctx.Produits.Add(new Produit()
            {
                Nom= produitAjoutDTO.Nom,
                Reference= produitAjoutDTO.Reference,
                DateReference= produitAjoutDTO.DateReference,
                Description= produitAjoutDTO.Description,
                Prix= produitAjoutDTO.Prix,
                pixels= produitAjoutDTO.Pixels
            });
            ctx.SaveChanges();
            return produitEntite.ProduitID;
        }

        public ProduitInfos ObtenirProduitParId(int produitId)
        {
            return ctx.Produits
                .Where(p => p.ProduitID == produitId)
                .Select( p=>new ProduitInfos
            {
                Nom=p.Nom,
                Prix=p.Prix,
                ProduitID=p.ProduitID,
                Reference=p.Reference
            }).Single();
        }

        public ProduitInfos RechercherProduit(string motcle)
        {
            return ctx.Produits
                .Where(p => p.Nom.Contains(motcle) || p.Description.Contains(motcle))
                .Select(p => 
                new ProduitInfos
                {
                    Nom = p.Nom,
                    Prix = p.Prix,
                    ProduitID = p.ProduitID,
                    Reference = p.Reference
                }).Single();
        }

        public IList<ProduitInfos> ObteniTousLesProduits()
        {
            return ctx.Produits
                .OrderByDescending(x=>x.Nom)
                .Select(p => 
                new ProduitInfos
                {
                    Nom = p.Nom,
                    Prix = p.Prix,
                    ProduitID = p.ProduitID,
                    Reference = p.Reference
                }
             )
             .ToList<ProduitInfos>();
        }

        public byte[] ObtenirLesPixelsPourUnProduit(int id)
        {
            return ctx.Produits
                .Where(p => p.ProduitID == id)
                .Select(p => p.pixels)
                .Single();
            
        }
    }
}
