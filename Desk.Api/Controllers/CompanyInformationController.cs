using Desk.Api.Models;
using Desk.Core.Domain.Company;
using Desk.Services.Company.CompanyInformations;
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
    public class CompanyInformationController : ControllerBase
    {
        #region fields
        private readonly ICompanyInformationService _companyInformationService;
        #endregion

        #region ctor
        public CompanyInformationController(ICompanyInformationService companyInformationService)
        {
            _companyInformationService = companyInformationService;
        }
        #endregion

        #region methods

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _companyInformationService.GetAllAsync();
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
                var results = await _companyInformationService.GetPagedListAsync(page, pageSize);
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
                var result = await _companyInformationService.GetByIdAsync(id);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CompanyInformation companyInformation)
        {
            try
            {
                var result = await _companyInformationService.AddAsync(companyInformation);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(CompanyInformation companyInformation)
        {
            try
            {
                var result = await _companyInformationService.UpdateAsync(companyInformation);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(CompanyInformation companyInformation)
        {
            try
            {
                var result = await _companyInformationService.SoftDeleteAsync(companyInformation);
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
                var result = await _companyInformationService.SoftDeleteByIdAsync(id);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(CompanyInformation companyInformation)
        {
            try
            {
                var result = await _companyInformationService.PermanentDeleteAsync(companyInformation);
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
                var result = await _companyInformationService.PermanentDeleteByIdAsync(id);
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
                var results = await _companyInformationService.GetAllDeletedAsync();
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
                var results = await _companyInformationService.GetDeletedPagedAsync(page, pageSize);
                return Ok(new ResponseResult { Result = results, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Restore")]
        public async Task<IActionResult> Restore(CompanyInformation companyInformation)
        {
            try
            {
                var result = await _companyInformationService.RestoreAsync(companyInformation);
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
                var result = await _companyInformationService.RestoreByIdAsync(id);
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
                var result = await _companyInformationService.RestoreByIdsAsync(ids);
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
