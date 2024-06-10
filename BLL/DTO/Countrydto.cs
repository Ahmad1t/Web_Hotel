using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class Countrydto
    {
        public int CountryId { get; set; }

        public string CountryName { get; set; } /*= null!;*/

        public bool IsActive { get; set; }
    }
}
