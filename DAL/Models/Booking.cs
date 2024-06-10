using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? CustomerId { get; set; }

    public int? FloorRoomId { get; set; }

    public int? EmpId { get; set; }

    public double? Amount { get; set; }

    public DateOnly? StartingDate { get; set; }

    public int? NumberOfNight { get; set; }

    public bool? IsActive { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employe? Emp { get; set; }

    public virtual FloorRoom? FloorRoom { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
