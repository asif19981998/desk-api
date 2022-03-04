using Desk.Api.Models;
using Desk.Core.Domain.Payment;
using Desk.Services.Payments.MobileBankAccounts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileBankAccountController : ControllerBase
    {
        #region fields
        private readonly IMobileBankAccountService _mobileBankAccountService;
        #endregion

        #region ctor
        public MobileBankAccountController(IMobileBankAccountService mobileBankAccountService )
        {
            _mobileBankAccountService = mobileBankAccountService;
        }
        #endregion

        #region methods

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var mobileBankAccounts = await _mobileBankAccountService.GetAllAsync();
                return Ok(new ResponseResult { Result = mobileBankAccounts, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }

        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(MobileBankAccount mobileBankAccount)
        {
            try
            {
                var result = await _mobileBankAccountService.AddAsync(mobileBankAccount);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(MobileBankAccount mobileBankAccount)
        {
            try
            {
                var result = await _mobileBankAccountService.UpdateAsync(mobileBankAccount);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(MobileBankAccount mobileBankAccount)
        {
            try
            {
                var result = await _mobileBankAccountService.SoftDeleteAsync(mobileBankAccount);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(MobileBankAccount mobileBankAccount)
        {
            try
            {
                var result = await _mobileBankAccountService.PermanentDeleteAsync(mobileBankAccount);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("DeleteById/{id}")]
        public async Task<IActionResult> SoftDeleteById(long id)
        {
            try
            {
                var result = await _mobileBankAccountService.SoftDeleteByIdAsync(id);
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
