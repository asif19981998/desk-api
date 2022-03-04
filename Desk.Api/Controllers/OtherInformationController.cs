using Desk.Api.Models;
using Desk.Core.Domain.Employees;
using Desk.Services.Employees.OtherInformations;
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
    public class OtherInformationController : ControllerBase
    {
        #region fields
        private readonly IOtherInformationService _otherInformationService;
        #endregion

        #region ctor
        public OtherInformationController(IOtherInformationService otherInformationService)
        {
            _otherInformationService = otherInformationService;
        }
        #endregion

        #region methods

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var otherInformations = await _otherInformationService.GetAllAsync();
                return Ok(new ResponseResult { Result = otherInformations, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(OtherInformation otherInformation)
        {
            try
            {
                var result = await _otherInformationService.AddAsync(otherInformation);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(OtherInformation otherInformation)
        {
            try
            {
                var result = await _otherInformationService.UpdateAsync(otherInformation);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(OtherInformation otherInformation)
        {
            try
            {
                var result = await _otherInformationService.SoftDeleteAsync(otherInformation);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(OtherInformation otherInformation)
        {
            try
            {
                var result = await _otherInformationService.PermanentDeleteAsync(otherInformation);
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
