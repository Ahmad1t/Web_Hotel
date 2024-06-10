using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Employe
{
    public int EmpId { get; set; }

    public int UserId { get; set; }

    public int NationalityId { get; set; }

    public int? WorkingwithId { get; set; }

    public int CityId { get; set; }

    public string EmpLname { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string EmpPhonenumber { get; set; } = null!;

    public bool EmpGander { get; set; }

    public DateOnly EmpStartDay { get; set; }

    public double EmpSalary { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual City City { get; set; } = null!;

    public virtual ICollection<Manger> Mangers { get; set; } = new List<Manger>();

    public virtual Nationality Nationality { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual WorkingWith? Workingwith { get; set; }
}
