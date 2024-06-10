using AutoMapper;
using BLL.DTO;
using BLL.Service.FloorWFloorRoom;
using BLL.Wrapping;
using Microsoft.AspNetCore.Mvc;

namespace Web_Hotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloorWFloorRoomController
    {
        public FloorWFloorRoomService _floorWFloorRoomService;

        public FloorWFloorRoomController(FloorWFloorRoomService floorWFloorRoomService)
        {
            _floorWFloorRoomService = floorWFloorRoomService;
        }
        /*        [HttpPost("AddFloorWFloorRoom")]
                public async Task<ApiResponse<FloorWFloorRoomdto>> FloorWFloorRoomAsync(FloorWFloorRoomdto dto)
                {
                    var result = await _floorWFloorRoomService.CityAndRoomdtoAsync(dto);
                   // var result = await  //_cityWCountryService.CityAndCountryAsync(dto);
                    return result;
                }*/
        [HttpPost("AddF")]
        public async Task<ApiResponse<FloorWFloorRoomdto>> FloorWFloorRoomAsync(FloorWFloorRoomdto dto)
        {
            var result = await _floorWFloorRoomService.FloorWFloorRoomAsync(dto);
            return result;
        }
    }
}