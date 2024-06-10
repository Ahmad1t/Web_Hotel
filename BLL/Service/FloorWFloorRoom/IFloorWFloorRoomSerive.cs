using BLL.DTO;
using BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.FloorWFloorRoom
{
    public interface IFloorWFloorRoomSerive
    {
        Task<ApiResponse<FloorWFloorRoomdto>> FloorWFloorRoomAsync(FloorWFloorRoomdto dto);
    }
}
