using Desk.Api.Models;
using Desk.Core.Domain.Employees;
using Desk.Services.Employees.EmployeeExperiences;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desk.Api.Controllers.EmployeeExperiencemployees
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeExperienceController : ControllerBase
    {
        #region fields
        private readonly IEmployeeExperienceService _employeeExperienceService;
        #endregion

        #region ctor
        public EmployeeExperienceController(IEmployeeExperienceService employeeExperienceService)
        {
            _employeeExperienceService = employeeExperienceService;
        }
        #endregion

        #region methods

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var employeeExperiences = await _employeeExperienceService.GetAllAsync();
                return Ok(new ResponseResult { Result = employeeExperiences, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }

        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(EmployeeExperience employeeExperience)
        {
            try
            {
                var result = await _employeeExperienceService.AddAsync(employeeExperience);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(EmployeeExperience employeeExperience)
        {
            try
            {
                var result = await _employeeExperienceService.UpdateAsync(employeeExperience);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(EmployeeExperience employeeExperience)
        {
            try
            {
                var result = await _employeeExperienceService.SoftDeleteAsync(employeeExperience);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(EmployeeExperience employeeExperience)
        {
            try
            {
                var result = await _employeeExperienceService.PermanentDeleteAsync(employeeExperience);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }

        #endregion
    }

}
