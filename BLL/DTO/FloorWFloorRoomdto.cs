using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class FloorWFloorRoomdto
    {
        public int FloorRoomId { get; set; }

        public int? FloorId { get; set; }

        public int? RoomId { get; set; }

        public int? FloorNumber { get; set; }
    }
}
