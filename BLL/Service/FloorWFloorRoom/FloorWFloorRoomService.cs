using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using BLL.DTO;
using BLL.Wrapping;
using DAL.Models;
using DAL.Repositories.FloorRooms;
using DAL.Repositories.Floors;
namespace BLL.Service.FloorWFloorRoom
{
    public class FloorWFloorRoomService : IFloorWFloorRoomSerive
    {
        public readonly IFloorRoomRepo _floorRoomRepo;
        public readonly IFloorRepo _floorRepo;
        public readonly IMapper _mapper;

        public FloorWFloorRoomService(IFloorRoomRepo floorRoomRepo, IFloorRepo floorRepo, IMapper mapper)
        {
            _floorRoomRepo = floorRoomRepo;
            _floorRepo = floorRepo;
            _mapper = mapper;
        }

        public async Task<ApiResponse<FloorWFloorRoomdto>> FloorWFloorRoomAsync(FloorWFloorRoomdto dto)
        {
            ApiResponse<FloorWFloorRoomdto> responseob = new ApiResponse<FloorWFloorRoomdto>();

            using (var transaction = new TransactionScope(TransactionScopeOption.Required ,
                new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted },
                TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var FloorValue = new Floordto();
                    FloorValue = _mapper.Map<Floordto>(dto);
                    _floorRepo.Add(_mapper.Map<Floor>(FloorValue));

                    var FloorRoomValue = new FloorRoomdto();
                    FloorRoomValue.FloorId = FloorRoomValue.FloorId;

                    FloorRoomValue = _mapper.Map<FloorRoomdto>(dto);
                    _floorRoomRepo.Add(_mapper.Map<FloorRoom>(FloorRoomValue));

                    transaction.Complete();

                    responseob.Data = _mapper.Map<FloorWFloorRoomdto>(FloorValue);
                    responseob.Data = _mapper.Map<FloorWFloorRoomdto>(FloorRoomValue);
                    return responseob;
                }
                catch (Exception ex)
                {
                    transaction.Dispose();
                    throw;
                }
            }
        }
    }
}