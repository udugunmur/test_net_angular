using Core.Data.Domain.TechnicalDbModel;
using System.Collections.Generic;

namespace Core.Data.Repositories
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetProjects();
    }
}