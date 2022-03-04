using Desk.Core.Domain.Core;
using Desk.Core.Miscellaneous;
using Desk.Infrastructure.Data;
using Desk.Infrastructure.Extensions;
using Desk.Services.Clients.Clients;
using Desk.Services.Company.CompanyInformations;
using Desk.Services.Core.Countries.Models;
using Desk.Services.Core.States;
using Desk.Services.Employees.ContactInformations;
using Desk.Services.Employees.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.Countries
{
    public class CountryService : ICountryService
    {
        private readonly IEntityRepository<Country> _repository;
        private readonly IEmployeeService _employeeService;
        private readonly IStateService _stateService;
        private readonly IClientService _clientService;
        private readonly ICompanyInformationService _companyInformationService;
        private readonly IContactInformationService _contactInformationService;

        public CountryService(
            IEntityRepository<Country> repository,
            IEmployeeService employeeService,
            IStateService stateService,
            IClientService clientSerivce,
            ICompanyInformationService companyInformationService,
            IContactInformationService contactInformationService




            )
        {
            _repository = repository;
            _employeeService = employeeService;
            _stateService = stateService;
            _clientService = clientSerivce;
            _companyInformationService = companyInformationService;
            _contactInformationService = contactInformationService;

        }
        public async Task<Country> AddAsync(Country model)
        {
            model.CreatedOn = DateTime.Now;
            return await _repository.AddAsync(model);
        }

        public async Task<bool> PermanentDeleteAsync(Country model)
        {
            return await _repository.PermanentDeleteAsync(model);
        }

        public async Task<bool> PermanentDeleteByIdAsync(long id)
        {
            return await _repository.PermanentDeleteByIdAsync(id);
        }
        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            return await _repository.GetAllAsync();



        }

        public async Task<List<CountryViewModel>> GetAllDataAsync()
        {
            List<CountryViewModel> countryViewModels = new List<CountryViewModel>();
            var countries = await _repository.GetAllAsync();
            
            foreach (var item in countries)
            {

                CountryViewModel country = new CountryViewModel();
                country.Id = item.Id;
                country.name = item.Name;
                country.EmployeeCount = _employeeService.TotalCount();
                country.ClientCount = _clientService.TotalCount();
                country.StateCount = _stateService.TotalCount();
                country.CompanyContactInformationCount = _companyInformationService.TotalCount();
                country.ContactInformationCount = _contactInformationService.TotalCount();
               
                countryViewModels.Add(country);

            }

            return countryViewModels;
        }

        public async Task<Country> GetByIdAsync(long id)
        {
            return await _repository.GetByIdAsync(id);
        }


        public int TotalCount()
        {
            return _repository.CountAsync().Result;
        }

        public async Task<bool> UpdateAsync(Country model)
        {
            return await _repository.UpdateAsync(model);
        }

        public async Task<bool> SoftDeleteAsync(Country model)
        {
            return await _repository.SoftDeleteAsync(model);
        }

        public async Task<bool> SoftDeleteByIdAsync(long id)
        {
            return await _repository.SoftDeleteByIdAsync(id);
        }

      public async  Task<PagedModel<Country>> GetPagedListAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList = await _repository.GetAllPagedAsync(recSkip, pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
           
            PagedModel<Country> pagedModel = new PagedModel<Country>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }

        public async Task<PagedModel<Country>> GetDeletedPagedAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList =await  _repository.GetDeletedPagedAsync(recSkip,pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
            PagedModel<Country> pagedModel = new PagedModel<Country>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }

        public async Task<IEnumerable<Country>> GetAllDeletedAsync()
        {
            return await _repository.GetAllDeletedAsync();
        }

        public async Task<bool> RestoreAsync(Country model)
        {
            return await _repository.RestoreAsync(model);
        }

        public async Task<bool> RestoreByIdAsync(long id)
        {
            return await _repository.RestoreByIdAsync(id);
        }

        public async Task<bool> RestoreByIdsAsync(List<long> ids)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> MultipleRowPermanentDelete(int[] ids)
        {
           
            bool res=false;
            foreach (var id in ids)
            {
              res =  await _repository.PermanentDeleteByIdAsync(id);
            }

            return res;
            
        }
    }
}
