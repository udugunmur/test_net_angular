using Core.Data.Domain.TechnicalDbModel;
using System.Collections.Generic;

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
            return _dbContext.Set<Project>();
        }
    }
}