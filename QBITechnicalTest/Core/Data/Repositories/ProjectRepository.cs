using Core.Data.Domain.TechnicalDbModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        #region Private and protected properties

        private readonly TechnicalTestDBContext _dbContext;

        #endregion

        #region Constructor

        public ProjectRepository(TechnicalTestDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        public IEnumerable<Project> GetProjects()
        {
            return _dbContext.Set<Project>()
                .Include(r=> r.Country)
                .Include(r => r.State)
                .Include(r => r.Tech).ToList();
        }

        public async Task<IEnumerable<DeviceType>> GetDeviceType()
        {
            return await _dbContext.Set<DeviceType>().ToListAsync();
        }

        public async Task<DeviceType> GetDeviceTypeByID(int ID)
        {
            return await _dbContext.Set<DeviceType>().FindAsync(ID);
        }

        public async Task<IEnumerable<DeviceType>> GetDeviceTypeByTypeId(int ID)
        {
            return await _dbContext.Set<DeviceType>().Where(x => x.DeviceTypeId == ID).ToListAsync();
        }

        public async Task<DeviceType> InsertDeviceType(DeviceType obj)
        {
            _dbContext.DeviceType.Add(obj);
            await _dbContext.SaveChangesAsync();
            return obj;
        }

        public async Task<DeviceType> UpdateDeviceType(DeviceType obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return obj;
        }

        public bool DeleteDeviceType(int ID)
        {
            bool result = false;
            var department = _dbContext.DeviceType.Find(ID);
            if (department != null) {
                _dbContext.Entry(department).State = EntityState.Deleted;
                _dbContext.SaveChanges();
                result = true;
            } else {
                result = false;
            }
            return result;
        }
    }
}