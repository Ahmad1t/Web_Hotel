using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class Citydto
    {
        public int CityId { get; set; }

        public int CountryId { get; set; }

        public string CityName { get; set; } /*= null!;*/

        public int IsActive { get; set; }
    }
}
