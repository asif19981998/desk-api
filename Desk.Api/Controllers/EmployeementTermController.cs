using Desk.Api.Models;
using Desk.Core.Domain.Employees;
using Desk.Services.Employees.EmployeementTerms;
using Desk.Services.Employees.EmployeementTerms;
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
    public class EmployeementTermController : ControllerBase
    {
        #region fields
        private readonly IEmployeementTermService _employeementTermService;
        #endregion

        #region ctor
        public EmployeementTermController(IEmployeementTermService employeementTermService)
        {
            _employeementTermService = employeementTermService;
        }
        #endregion

        #region methods

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var employeementTerms = await _employeementTermService.GetAllAsync();
                return Ok(new ResponseResult { Result = employeementTerms, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }

        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(EmployeementTerm employeementTerm)
        {
            try
            {
                var result = await _employeementTermService.AddAsync(employeementTerm);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(EmployeementTerm employeementTerm)
        {
            try
            {
                var result = await _employeementTermService.UpdateAsync(employeementTerm);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(EmployeementTerm employeementTerm)
        {
            try
            {
                var result = await _employeementTermService.SoftDeleteAsync(employeementTerm);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(EmployeementTerm employeementTerm)
        {
            try
            {
                var result = await _employeementTermService.PermanentDeleteAsync(employeementTerm);
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
