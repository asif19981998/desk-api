using Desk.Api.Models;
using Desk.Core.Domain.Payment;
using Desk.Services.Payments.BankAccounts;
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
    public class BankAccountController : ControllerBase
    {
        #region fields
        private readonly IBankAccountService _bankAccountService;
        #endregion

        #region ctor
        public BankAccountController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }
        #endregion

        #region methods

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var bankAccounts = await _bankAccountService.GetAllAsync();
                return Ok(new ResponseResult { Result = bankAccounts, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }

        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(BankAccount bankAccount)
        {
            try
            {
                var result = await _bankAccountService.AddAsync(bankAccount);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(BankAccount bankAccount)
        {
            try
            {
                var result = await _bankAccountService.UpdateAsync(bankAccount);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(BankAccount bankAccount)
        {
            try
            {
                var result = await _bankAccountService.SoftDeleteAsync(bankAccount);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(BankAccount bankAccount)
        {
            try
            {
                var result = await _bankAccountService.PermanentDeleteAsync(bankAccount);
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
