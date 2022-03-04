using Desk.Api.Models;
using Desk.Core.Domain.Employees;
using Desk.Services.Employees.EmployeeEducations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desk.Api.Controllers.Employees
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeEducationController : ControllerBase
    {
        #region fields
        private readonly IEmployeeEducationService _employeeEducationService;
        #endregion

        #region ctor
        public EmployeeEducationController(IEmployeeEducationService employeeEducationService)
        {
            _employeeEducationService = employeeEducationService;
        }
        #endregion

        #region methods

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var employeeEducations = await _employeeEducationService.GetAllAsync();
                return Ok(new ResponseResult { Result = employeeEducations, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }

        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(EmployeeEducation employeeEducation)
        {
            try
            {
                var result = await _employeeEducationService.AddAsync(employeeEducation);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(EmployeeEducation employeeEducation)
        {
            try
            {
                var result = await _employeeEducationService.UpdateAsync(employeeEducation);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(EmployeeEducation employeeEducation)
        {
            try
            {
                var result = await _employeeEducationService.SoftDeleteAsync(employeeEducation);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(EmployeeEducation employeeEducation)
        {
            try
            {
                var result = await _employeeEducationService.PermanentDeleteAsync(employeeEducation);
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
