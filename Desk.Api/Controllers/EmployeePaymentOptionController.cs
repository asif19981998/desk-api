using Desk.Api.Models;
using Desk.Core.Domain.Employees;
using Desk.Services.Employees.EmployeePaymentOptions;
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
    public class EmployeePaymentOptionController : ControllerBase
    {
        #region fields
        private readonly IEmployeePaymentOptionService _employeementPaymentService;
        #endregion

        #region ctor
        public EmployeePaymentOptionController(IEmployeePaymentOptionService employeementPaymentOptionService)
        {
            _employeementPaymentService = employeementPaymentOptionService;
        }
        #endregion

        #region methods

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var employeementPaymentOptions = await _employeementPaymentService.GetAllAsync();
                return Ok(new ResponseResult { Result = employeementPaymentOptions, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }

        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(EmployeePaymentOption employeementPaymentOption)
        {
            try
            {
                var result = await _employeementPaymentService.AddAsync(employeementPaymentOption);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(EmployeePaymentOption employeementPaymentOption)
        {
            try
            {
                var result = await _employeementPaymentService.UpdateAsync(employeementPaymentOption);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(EmployeePaymentOption employeementPaymentOption)
        {
            try
            {
                var result = await _employeementPaymentService.SoftDeleteAsync(employeementPaymentOption);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(EmployeePaymentOption employeementPaymentOption)
        {
            try
            {
                var result = await _employeementPaymentService.PermanentDeleteAsync(employeementPaymentOption);
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
