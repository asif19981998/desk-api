using AutoMapper;
using Desk.Api.Models;
using Desk.Core.Domain.Employees;
using Desk.Infrastructure.SqlExtensions.SqlSequence;
using Desk.Services.Auth;
using Desk.Services.Auth.Authentication;
using Desk.Services.Auth.Authentication.Models;
using Desk.Services.Employees.Employees;
using Desk.Services.Employees.Employees.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desk.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EmployeeController : ControllerBase
    {
        #region Config
        private IEmployeeService _employeeService;
        //private ICityService _cityService;
        //private ICountryService _countryService;
        //private IStateService _stateService;
        //private IDepartmentService _departmentService;
        //private IDesignationService _designationService;
        private IAuthenticationService _authenticationService;
        private IMapper _mapper;
        private ISqlSequenceService sqlSequence;
        public EmployeeController(IEmployeeService employeeService,
            IAuthenticationService authenticationService,
            IMapper mapper,
            ISqlSequenceService sqlSequence
            //ICityService cityService, 
            //IStateService stateService,
            //ICountryService countryService,
            //IDepartmentService departmentService,
            //IDesignationService designationService
            )
        {
            _employeeService = employeeService;
            _authenticationService = authenticationService;
            _mapper = mapper;
            //_cityService = cityService;
            //_stateService = stateService;
            //_countryService = countryService;
            //_departmentService = departmentService;
            //_designationService = designationService;
        }

        #endregion

        #region methods
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _employeeService.GetAllAsync();
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
                var results = await _employeeService.GetPagedListAsync(page, pageSize);
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
                var result = await _employeeService.GetByIdAsync(id);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
       
        public async Task<IActionResult> Post(Employee employee)
        {
            try
            {
                var result = await _employeeService.AddAsync(employee);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(Employee employee)
        {
            try
            {
                var result = await _employeeService.UpdateAsync(employee);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> SoftDelete(Employee employee)
        {
            try
            {
                var result = await _employeeService.SoftDeleteAsync(employee);
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
                var result = await _employeeService.SoftDeleteByIdAsync(id);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("PermanentDelete")]
        public async Task<IActionResult> HardDelete(Employee employee)
        {
            try
            {
                var result = await _employeeService.PermanentDeleteAsync(employee);
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
                var result = await _employeeService.PermanentDeleteByIdAsync(id);
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
                var countries = await _employeeService.GetAllDeletedAsync();
                return Ok(new ResponseResult { Result = countries, IsSuccess = true, Message = "" });
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
                var results = await _employeeService.GetDeletedPagedAsync(page, pageSize);
                return Ok(new ResponseResult { Result = results, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        [HttpPost]
        [Route("Restore")]
        public async Task<IActionResult> Restore(Employee employee)
        {
            try
            {
                var result = await _employeeService.RestoreAsync(employee);
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
                var result = await _employeeService.RestoreByIdAsync(id);
                return Ok(new ResponseResult { Result = result, IsSuccess = true, Message = "" });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseResult { Result = null, IsSuccess = false, Message = ex.Message });
            }
        }


        #endregion
        #region Post
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(EmployeeVM model)
        {
            var employee = _mapper.Map<Employee>(model);

            var result = await _employeeService.AddAsync(employee);

            ///Make User 
            if (model == null)
                throw new NullReferenceException("Model is null");

            if (model.Password != model.PasswordConfirm)
            {
                return Ok("Password Doesn't match");
            }
            AuthVM vm = new AuthVM()
            {
                Email = model.Email,
                Password = model.Password,
                PasswordConfirm = model.Password,
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            var data = _authenticationService.RegisterByCreatingAsync(vm);


            if (result.Id > 0)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }

        }
        #endregion

        #region Put
        public async Task<IActionResult> Put(Employee model)
        {
            return Ok();//Not implemented yet
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(); //Not implemented yet
        }
        #endregion





    }
}
