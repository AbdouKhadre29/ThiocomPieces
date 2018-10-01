using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiocomPieces.DAL;
using ThiocomPieces.DTO;

namespace ThiocomPieces.BLL
{
   public class RoleServices
    {

        public RoleInfos ObtenirRoleParId(int RoleID)
        {
            using (ThiocomPiecesDbContext ctx = new ThiocomPiecesDbContext())
            {
                return ctx.RolesCustom
                    .Where(r => r.RoleId == RoleID)
                    .Select(r =>
                    new RoleInfos
                    {

                    })
                    .Single();
                
            }
        }
}
}
