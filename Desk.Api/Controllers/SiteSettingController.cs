using Desk.Api.Models;
using Desk.Core.Domain.Core;
using Desk.Services.Core.SiteSettings;
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
    public class SiteSettingController : ControllerBase
    {
        #region fields
        private readonly ISiteSettingService _siteSettingService;
        #endregion

        #region ctor
        public SiteSettingController(ISiteSettingService siteSettingService)
        {
            _siteSettingService = siteSettingService;
        }
        #endregion


        #region methods
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _siteSettingService.FirstOrDefaultAsync();
                return Ok(new ResponseResult { Result = results, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }

        }


       

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(SiteSetting siteSetting)
        {
            try
            {
                var result = await _siteSettingService.AddAsync(siteSetting);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(SiteSetting siteSetting)
        {
            try
            {
                var result = await _siteSettingService.UpdateAsync(siteSetting);
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
