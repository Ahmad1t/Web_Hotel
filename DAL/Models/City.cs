using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class City
{
    public int CityId { get; set; }

    public int? CountryId { get; set; }

    public string? CityName { get; set; }

    public int? IsActive { get; set; }

    public virtual Country? Country { get; set; }

    public virtual ICollection<Employe> Employes { get; set; } = new List<Employe>();
}
