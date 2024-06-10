using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public string? RoomNumber { get; set; }

    public virtual ICollection<FloorRoom> FloorRooms { get; set; } = new List<FloorRoom>();
}
