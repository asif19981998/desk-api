﻿using Desk.Core.Domain.Company;
using Desk.Core.Miscellaneous;
using Desk.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Company.CompanyContactInformations
{
    public class CompanyContactInformationService : ICompanyContactInformationService
    {
        private readonly IEntityRepository<CompanyContactInformation> _repository;
        public CompanyContactInformationService(IEntityRepository<CompanyContactInformation> repository)
        {
            _repository = repository;
        }

        public async Task<CompanyContactInformation> AddAsync(CompanyContactInformation model)
        {
            model.CreatedOn = DateTime.Now;
            return await _repository.AddAsync(model);
        }

        public async Task<bool> PermanentDeleteAsync(CompanyContactInformation model)
        {
            return await _repository.PermanentDeleteAsync(model);
        }

        public async Task<bool> PermanentDeleteByIdAsync(long id)
        {
            return await _repository.PermanentDeleteByIdAsync(id);
        }

        public async Task<IEnumerable<CompanyContactInformation>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<CompanyContactInformation> GetByIdAsync(long id)
        {
            return await _repository.GetByIdAsync(id);
        }


        public int TotalCount()
        {
            return _repository.CountAsync().Result;
        }

        public async Task<bool> UpdateAsync(CompanyContactInformation model)
        {
            return await _repository.UpdateAsync(model);
        }

        public async Task<bool> SoftDeleteAsync(CompanyContactInformation model)
        {
            return await _repository.SoftDeleteAsync(model);
        }

        public async Task<bool> SoftDeleteByIdAsync(long id)
        {
            return await _repository.SoftDeleteByIdAsync(id);
        }

        public async Task<PagedModel<CompanyContactInformation>> GetPagedListAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList = await _repository.GetAllPagedAsync(recSkip, pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
            PagedModel<CompanyContactInformation> pagedModel = new PagedModel<CompanyContactInformation>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }

        public async Task<PagedModel<CompanyContactInformation>> GetDeletedPagedAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList = await _repository.GetDeletedPagedAsync(recSkip, pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
            PagedModel<CompanyContactInformation> pagedModel = new PagedModel<CompanyContactInformation>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }

        public async Task<IEnumerable<CompanyContactInformation>> GetAllDeletedAsync()
        {
            return await _repository.GetAllDeletedAsync();
        }

        public async Task<bool> RestoreAsync(CompanyContactInformation model)
        {
            return await _repository.RestoreAsync(model);
        }

        public async Task<bool> RestoreByIdAsync(long id)
        {
            return await _repository.RestoreByIdAsync(id);
        }

        public Task<bool> RestoreByIdsAsync(List<long> ids)
        {
            throw new NotImplementedException();
        }

    }
}
