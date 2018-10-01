using System;

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thiocom.Entities;

namespace ThiocomPieces.DAL
{
    public class ThiocomPiecesDbContext: DbContext
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<RoleCustom> RolesCustom { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public ThiocomPiecesDbContext() : base("name=ThiocomDBString") { }
    }
}
