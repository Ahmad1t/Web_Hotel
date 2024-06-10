using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Nationality
{
    public int NationalityId { get; set; }

    public string? NationalityName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Employe> Employes { get; set; } = new List<Employe>();
}
