using BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Wrapping;
namespace BLL.Service._Generic
{
    public interface IGenericService<Dto> where Dto : class
    {
        ApiResponse<IEnumerable<Dto>> GetAll();
        ApiResponse<Dto> GetById(int id);
        ApiResponse<Dto> Add(Dto obj);
        ApiResponse<Dto> Update(Dto obj);
        ApiResponse<bool> Delete(int id);
        ApiResponse<bool> Delete(Dto obj);
    }
}
