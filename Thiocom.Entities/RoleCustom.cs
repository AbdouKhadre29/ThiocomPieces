using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thiocom.Entities
{
    public class RoleCustom
    {
        public int RoleId { get; set; }
        [Required]
        public string Title { get; set; }
        public ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
