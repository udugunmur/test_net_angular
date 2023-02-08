using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.Application;
using Core.Data.Domain.TechnicalDbModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        #region Private and protected properties

        private readonly IProjectLogic _projectLogic;
        private readonly IMapper _mapperService;

        #endregion

        #region Constructor

        public DeviceController(IProjectLogic projectLogic, IMapper mapperService)
        {
            _projectLogic = projectLogic;
            _mapperService = mapperService;
        }

        #endregion
        
        [HttpGet]
        public async Task<IActionResult> Get(int? deviceTypeId) {
            if (deviceTypeId != null)
            {
                return Ok(await _projectLogic.GetDeviceTypeByID(deviceTypeId.Value));
            }
            return Ok(await _projectLogic.GetDeviceType());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeptById(int id) {
            return Ok(await _projectLogic.GetDeviceTypeByID(id));
        }
        [HttpPost]
        public async Task<IActionResult> Post(DeviceType dep) {
            var result = await _projectLogic.InsertDeviceType(dep);
            if (result.DeviceTypeId == 0) {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok("Added Successfully");
        }
        [HttpPut]
        public async Task<IActionResult> Put(DeviceType dep) {
            await _projectLogic.UpdateDeviceType(dep);
            return Ok("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            _projectLogic.DeleteDeviceType(id);
            return new JsonResult("Deleted Successfully");
        }
    }
}