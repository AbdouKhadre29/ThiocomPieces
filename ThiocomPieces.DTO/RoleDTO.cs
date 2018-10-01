using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiocomPieces.DTO
{
    public class RoleDTO
    {
        public int RoleId { get; set; }
        public string Titre { get; set; }
    }

    public class RoleInfos:RoleDTO
    {

    }

    public class RoleAjout
    {
        public string Titre { get; set; }
    }
}
