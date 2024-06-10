using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Manger
{
    public int MangerId { get; set; }

    public int EmpId { get; set; }

    public bool IsActive { get; set; }

    public virtual Employe Emp { get; set; } = null!;

    public virtual ICollection<WorkingWith> WorkingWiths { get; set; } = new List<WorkingWith>();
}
