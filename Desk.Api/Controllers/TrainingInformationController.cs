using Desk.Api.Models;
using Desk.Core.Domain.Employees;
using Desk.Services.Employees.TrainingInformaitons;
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
    public class TrainingInformationController : ControllerBase
    {
        #region fields
        private readonly ITrainingInformaitonService _trainingInformationService;
        #endregion

        #region ctor
        public TrainingInformationController(ITrainingInformaitonService trainingInformationService)
        {
            _trainingInformationService = trainingInformationService;
        }
        #endregion

        #region methods

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var trainingInformations = await _trainingInformationService.GetAllAsync();
                return Ok(new ResponseResult { Result = trainingInformations, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }

        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(TrainingInformation trainingInformation)
        {
            try
            {
                var result = await _trainingInformationService.AddAsync(trainingInformation);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(TrainingInformation trainingInformation)
        {
            try
            {
                var result = await _trainingInformationService.UpdateAsync(trainingInformation);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(TrainingInformation trainingInformation)
        {
            try
            {
                var result = await _trainingInformationService.SoftDeleteAsync(trainingInformation);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(TrainingInformation trainingInformation)
        {
            try
            {
                var result = await _trainingInformationService.PermanentDeleteAsync(trainingInformation);
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
