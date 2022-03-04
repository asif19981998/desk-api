using Desk.Api.Models;
using Desk.Core.Domain.Attendance;
using Desk.Services.Attendance.Holidays;
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
    public class HolidayController : ControllerBase
    {
        #region fields
        private readonly IHolidayService _holidayService;
        #endregion
        #region ctor
        public HolidayController(IHolidayService holidayService)
        {
            _holidayService = holidayService;
        }
        #endregion

        #region methods

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _holidayService.GetAllAsync();
                return Ok(new ResponseResult { Result = results, IsSuccess = true, Message = "" });
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
                var results = await _holidayService.GetPagedListAsync(page, pageSize);
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
                var result = await _holidayService.GetByIdAsync(id);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(Holiday holiday)
        {
            try
            {
                var result = await _holidayService.AddAsync(holiday);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(Holiday holiday)
        {
            try
            {
                var result = await _holidayService.UpdateAsync(holiday);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(Holiday holiday)
        {
            try
            {
                var result = await _holidayService.SoftDeleteAsync(holiday);
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
                var result = await _holidayService.SoftDeleteByIdAsync(id);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(Holiday holiday)
        {
            try
            {
                var result = await _holidayService.PermanentDeleteAsync(holiday);
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
                var result = await _holidayService.PermanentDeleteByIdAsync(id);
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
                var results = await _holidayService.GetAllDeletedAsync();
                return Ok(new ResponseResult { Result = results, IsSuccess = true, Message = "" });
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
                var results = await _holidayService.GetDeletedPagedAsync(page, pageSize);
                return Ok(new ResponseResult { Result = results, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Restore")]
        public async Task<IActionResult> Restore(Holiday holiday)
        {
            try
            {
                var result = await _holidayService.RestoreAsync(holiday);
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
                var result = await _holidayService.RestoreByIdAsync(id);
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
                var result = await _holidayService.RestoreByIdsAsync(ids);
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
