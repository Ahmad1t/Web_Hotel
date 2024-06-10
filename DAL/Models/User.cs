using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class User
{
    public int UserId { get; set; }

    public int? RoleId { get; set; }

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Employe> Employes { get; set; } = new List<Employe>();

    public virtual Role? Role { get; set; }
}
