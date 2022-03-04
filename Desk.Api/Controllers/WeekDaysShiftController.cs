using Desk.Api.Models;
using Desk.Core.Domain.DutyShift_Schedules;
using Desk.Services.DutyShift_Schedules.WeekDaysShifts;
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
    public class WeekDaysShiftController : ControllerBase
    {
        #region fields
        private readonly IWeekDaysShiftService _weekDaysShiftService;
        #endregion
        #region ctor
        public WeekDaysShiftController(IWeekDaysShiftService weekDaysShiftService)
        {
            _weekDaysShiftService = weekDaysShiftService;
        }
        #endregion
        #region methods


        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var weekDaysShifts = await _weekDaysShiftService.GetAllAsync();
                return Ok(new ResponseResult { Result = weekDaysShifts, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }

        }


        [HttpGet]
        [Route("GetPaginated/{page}/{pageSize}")]
        public async Task<IActionResult> GetPaginated(int page = 1, int pageSize = 10)
        {
            try
            {
                var results = await _weekDaysShiftService.GetPagedListAsync(page, pageSize);
                return Ok(new ResponseResult { Result = results, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("GetDetails/{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            try
            {
                var weekDaysShift = await _weekDaysShiftService.GetByIdAsync(id);
                return Ok(new ResponseResult { Result = weekDaysShift, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(WeekDaysShift weekDaysShift)
        {
            try
            {
                var result = await _weekDaysShiftService.AddAsync(weekDaysShift);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(WeekDaysShift weekDaysShift)
        {
            try
            {
                var result = await _weekDaysShiftService.UpdateAsync(weekDaysShift);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(WeekDaysShift weekDaysShift)
        {
            try
            {
                var result = await _weekDaysShiftService.SoftDeleteAsync(weekDaysShift);
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
                var result = await _weekDaysShiftService.SoftDeleteByIdAsync(id);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(WeekDaysShift weekDaysShift)
        {
            try
            {
                var result = await _weekDaysShiftService.PermanentDeleteAsync(weekDaysShift);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpDelete]
        [Route("PermanentDeleteById/{id}")]
        public async Task<IActionResult> HardDeleteById(long id)
        {
            try
            {
                var result = await _weekDaysShiftService.PermanentDeleteByIdAsync(id);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("Deleted")]
        public async Task<IActionResult> Deleted()
        {
            try
            {
                var weekDaysShift = await _weekDaysShiftService.GetAllDeletedAsync();
                return Ok(new ResponseResult { Result = weekDaysShift, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("DeletedPaginated/{page}/{pageSize}")]
        public async Task<IActionResult> DeletedPaginated(int page = 1, int pageSize = 10)
        {
            try
            {
                var results = await _weekDaysShiftService.GetDeletedPagedAsync(page, pageSize);
                return Ok(new ResponseResult { Result = results, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Restore")]
        public async Task<IActionResult> Restore(WeekDaysShift weekDaysShift)
        {
            try
            {
                var result = await _weekDaysShiftService.RestoreAsync(weekDaysShift);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("RestoreById/{id}")]
        public async Task<IActionResult> RestoreById(long id)
        {
            try
            {
                var result = await _weekDaysShiftService.RestoreByIdAsync(id);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("RestoreByIds/{ids}")]
        public async Task<IActionResult> RestoreByIds(List<long> ids)
        {
            try
            {
                var result = await _weekDaysShiftService.RestoreByIdsAsync(ids);
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
