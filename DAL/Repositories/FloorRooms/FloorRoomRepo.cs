using DAL.Models;
using DAL.Repositories._Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.FloorRooms
{
    public class FloorRoomRepo : GenericRepository<FloorRoom>, IFloorRoomRepo
    {
        public FloorRoomRepo(HotelContext hotelContext) : base(hotelContext) 
        {

        }
    }
}
