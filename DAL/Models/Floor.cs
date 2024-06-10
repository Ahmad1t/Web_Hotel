using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Floor
{
    public int FloorId { get; set; }

    public int? FloorNumber { get; set; }

    public virtual ICollection<FloorRoom> FloorRooms { get; set; } = new List<FloorRoom>();
}
