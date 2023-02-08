using Core.Data.Domain.TechnicalDbModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Application
{
    public interface IProjectLogic
    {
        IEnumerable<Project> GetProjects();
        Task<IEnumerable<DeviceType>> GetDeviceType();
        Task<DeviceType> GetDeviceTypeByID(int ID);
        Task<IEnumerable<DeviceType>> GetDeviceTypeByTypeId(int ID);
        Task<DeviceType> InsertDeviceType(DeviceType obj);
        Task<DeviceType> UpdateDeviceType(DeviceType obj);
        bool DeleteDeviceType(int ID);
    }
}
