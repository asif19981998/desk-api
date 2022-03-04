using Desk.Api.Models;
using Desk.Core.Domain.Employees;
using Desk.Services.Employees.EmployeeSalaries;
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
    public class EmployeeSalaryController : ControllerBase
    {
        #region fields
        private readonly IEmployeeSalaryService _employeeSalaryService;
        #endregion

        #region ctor
        public EmployeeSalaryController(IEmployeeSalaryService employeeSalaryService)
        {
            _employeeSalaryService = employeeSalaryService;
        }
        #endregion

        #region methods

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var employeeSalarys = await _employeeSalaryService.GetAllAsync();
                return Ok(new ResponseResult { Result = employeeSalarys, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }

        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(EmployeeSalary employeeSalary)
        {
            try
            {
                var result = await _employeeSalaryService.AddAsync(employeeSalary);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(EmployeeSalary employeeSalary)
        {
            try
            {
                var result = await _employeeSalaryService.UpdateAsync(employeeSalary);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(EmployeeSalary employeeSalary)
        {
            try
            {
                var result = await _employeeSalaryService.SoftDeleteAsync(employeeSalary);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(EmployeeSalary employeeSalary)
        {
            try
            {
                var result = await _employeeSalaryService.PermanentDeleteAsync(employeeSalary);
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
