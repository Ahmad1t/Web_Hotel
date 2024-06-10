using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Payment
{
    public string PaymentId { get; set; } = null!;

    public int BookingId { get; set; }

    public int PaymentMethodId { get; set; }

    public int CustomerId { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual PaymentMethod PaymentMethod { get; set; } = null!;
}
