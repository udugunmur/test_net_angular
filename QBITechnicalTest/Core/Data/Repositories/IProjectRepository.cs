using Core.Data.Domain.TechnicalDbModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetProjects();
        
        Task<IEnumerable<DeviceType>> GetDeviceType();
        Task<DeviceType> GetDeviceTypeByID(int ID);
        Task<IEnumerable<DeviceType>> GetDeviceTypeByTypeId(int ID);
        Task<DeviceType> InsertDeviceType(DeviceType objDepartment);
        Task<DeviceType> UpdateDeviceType(DeviceType objDepartment);
        bool DeleteDeviceType(int ID); 
    }
}