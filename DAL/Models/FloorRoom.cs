using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class FloorRoom
{
    public int FloorRoomId { get; set; }

    public int? FloorId { get; set; }

    public int? RoomId { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Floor? Floor { get; set; }

    public virtual Room? Room { get; set; }
}
