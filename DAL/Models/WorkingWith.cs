using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class WorkingWith
{
    public int WorkingwithId { get; set; }

    public int MangerId { get; set; }

    public virtual ICollection<Employe> Employes { get; set; } = new List<Employe>();

    public virtual Manger Manger { get; set; } = null!;
}
