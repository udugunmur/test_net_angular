using Core.Data.Domain.TechnicalDbModel;
using System.Collections.Generic;

namespace Core.Application
{
    public interface IProjectLogic
    {
        IEnumerable<Project> GetProjects();
    }
}
