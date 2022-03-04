using Desk.Api.Models;
using Desk.Core.Domain.Company;
using Desk.Services.Company.CompanyBranchs;
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
    public class CompanyBranchController : ControllerBase
    {
        #region fields
        private readonly ICompanyBranchService _companyBranchService;
        #endregion
        #region ctor
        public CompanyBranchController(ICompanyBranchService companyBranchService)
        {
            _companyBranchService = companyBranchService;
        }
        #endregion
        #region methods

        [HttpGet]
        //[Authorize]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var companyBranches = await _companyBranchService.GetAllAsync();
                return Ok(new ResponseResult { Result = companyBranches, IsSuccess = true, Message = "" });
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
                var results = await _companyBranchService.GetPagedListAsync(page, pageSize);
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
                var companyBranch = await _companyBranchService.GetByIdAsync(id);
                return Ok(new ResponseResult { Result = companyBranch, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CompanyBranch companyBranch)
        {
            try
            {
                var result = await _companyBranchService.AddAsync(companyBranch);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(CompanyBranch companyBranch)
        {
            try
            {
                var result = await _companyBranchService.UpdateAsync(companyBranch);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(CompanyBranch companyBranch)
        {
            try
            {
                var result = await _companyBranchService.SoftDeleteAsync(companyBranch);
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
                var result = await _companyBranchService.SoftDeleteByIdAsync(id);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(CompanyBranch companyBranch)
        {
            try
            {
                var result = await _companyBranchService.PermanentDeleteAsync(companyBranch);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpDelete]
        [Route("PermanentDeleteById/{id}")]
        public async Task<IActionResult> HardDeleteById(int id)
        {
            try
            {
                var result = await _companyBranchService.PermanentDeleteByIdAsync(id);
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
                var result = await _companyBranchService.GetAllDeletedAsync();
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }

        }

        //[HttpPost]
        //[Route("MultipleRowDelete")]
        //public async Task<IActionResult> Deleted(int[] ids)
        //{
        //    try
        //    {
        //        var res = await _companyBranchService.MultipleRowPermanentDelete(ids);
        //        return Ok(new ResponseResult { Result = res, IsSuccess = true, Message = "" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
        //    }

        //}



        [HttpGet]
        [Route("DeletedPaginated/{page}/{pageSize}")]
        public async Task<IActionResult> DeletedPaginated(int page = 1, int pageSize = 10)
        {
            try
            {
                var results = await _companyBranchService.GetDeletedPagedAsync(page, pageSize);
                return Ok(new ResponseResult { Result = results, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Restore")]
        public async Task<IActionResult> Restore(CompanyBranch companyBranch)
        {
            try
            {
                var result = await _companyBranchService.RestoreAsync(companyBranch);
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
                var result = await _companyBranchService.RestoreByIdAsync(id);
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
                var result = await _companyBranchService.RestoreByIdsAsync(ids);
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
