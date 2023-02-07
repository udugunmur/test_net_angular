using AutoMapper;
using Core.Application;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        #region Private and protected properties

        private readonly IProjectLogic _projectLogic;
        private readonly IMapper _mapperService;

        #endregion

        #region Constructor

        public ProjectController(IProjectLogic projectLogic, IMapper mapperService)
        {
            _projectLogic = projectLogic;
            _mapperService = mapperService;
        }

        #endregion

        [HttpGet]
        public IActionResult Get()
        {
            var entities = _projectLogic.GetProjects();
            return Ok(_mapperService.Map<IEnumerable<ProjectViewModel>>(entities));
        }
    }
}