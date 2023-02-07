using Core.Data.Domain.TechnicalDbModel;
using Core.Data.Repositories;
using System.Collections.Generic;

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
    }
}