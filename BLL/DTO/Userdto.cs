using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class Userdto
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public string UserName { get; set; } 

        public string UserPassword { get; set; } 

 /*       public bool IsActive { get; set; }

        public virtual ICollection<Employe> Employes { get; set; } = new List<Employe>();

        public virtual Role Role { get; set; } = null!;*/
    }
}
