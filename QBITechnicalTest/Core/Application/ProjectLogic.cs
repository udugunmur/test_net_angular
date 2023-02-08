using Core.Data.Domain.TechnicalDbModel;
using Core.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Application
{
    public class ProjectLogic : IProjectLogic
    {
        #region Private and protected properties

        private readonly IProjectRepository _projectRepository;

        #endregion

        #region Constructor

        public ProjectLogic(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        #endregion

        public IEnumerable<Project> GetProjects()
        {
            return _projectRepository.GetProjects();
        }

        public async Task<IEnumerable<DeviceType>> GetDeviceType()
        {
            return await _projectRepository.GetDeviceType();
        }

        public async Task<DeviceType> GetDeviceTypeByID(int ID)
        {
            return await _projectRepository.GetDeviceTypeByID(ID);
        }

        public async Task<IEnumerable<DeviceType>> GetDeviceTypeByTypeId(int ID)
        {
            return await _projectRepository.GetDeviceTypeByTypeId(ID);
        }

        public async Task<DeviceType> InsertDeviceType(DeviceType obj)
        {
            return await _projectRepository.InsertDeviceType(obj);
        }

        public async Task<DeviceType> UpdateDeviceType(DeviceType obj)
        {
            return await _projectRepository.UpdateDeviceType(obj);
        }

        public bool DeleteDeviceType(int ID)
        {
            return _projectRepository.DeleteDeviceType(ID);
        }
    }
}