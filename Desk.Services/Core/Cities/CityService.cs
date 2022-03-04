using Desk.Core.Domain.Core;
using Desk.Core.Miscellaneous;
using Desk.Infrastructure.Data;
using Desk.Services.Core.Cities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.Cities
{
    public class CityService : ICityService
    {
        #region fields
        private readonly IEntityRepository<City> _repository;
        #endregion
        #region ctor
        public CityService(IEntityRepository<City> repository)
        {
            _repository = repository;
        }
        #endregion
        #region methods
        public async Task<City> AddAsync(City model)
        {
            model.CreatedOn = DateTime.Now;
            return await _repository.AddAsync(model);
        }

        public async Task<bool> PermanentDeleteAsync(City model)
        {
            return await _repository.PermanentDeleteAsync(model);
        }

        public async Task<bool> PermanentDeleteByIdAsync(long id)
        {
            return await _repository.PermanentDeleteByIdAsync(id);
        }

        public async Task<IEnumerable<City>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<City> GetByIdAsync(long id)
        {
            return await _repository.GetByIdAsync(id);
        }


        public int TotalCount()
        {
            return _repository.CountAsync().Result;
        }

        public async Task<bool> UpdateAsync(CityViewModel model)
        {
            City city = maptocity(ref model);
            return await _repository.UpdateAsync(city);
        }

       

        public async Task<bool> SoftDeleteAsync(City model)
        {
            return await _repository.SoftDeleteAsync(model);
        }

        public async Task<bool> SoftDeleteByIdAsync(long id)
        {
            return await _repository.SoftDeleteByIdAsync(id);
        }

        public async Task<PagedModel<City>> GetPagedListAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList = await _repository.GetAllPagedAsync(recSkip, pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
            PagedModel<City> pagedModel = new PagedModel<City>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }

        public async Task<PagedModel<City>> GetDeletedPagedAsync(int page, int pageSize)
        {
            int resCount = TotalCount();
            var pagers = new PagedList(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var pagedList = await _repository.GetDeletedPagedAsync(recSkip, pagers.PageSize);
            int FirstSerialNumber = ((page * pageSize) - pageSize) + 1;
            PagedModel<City> pagedModel = new PagedModel<City>()
            {
                Models = pagedList,
                FirstSerialNumber = FirstSerialNumber,
                PagedList = pagers,
                TotalEntity = resCount
            };
            return pagedModel;
        }
        public async Task<bool> UpdateAsync(City model)
        {
            return await _repository.UpdateAsync(model);
        }

        public async Task<IEnumerable<City>> GetAllDeletedAsync()
        {
            return await _repository.GetAllDeletedAsync();
        }

        public async Task<bool> RestoreAsync(City model)
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
        #endregion
        #region properties
        private City maptocity(ref CityViewModel model)
        {
            City city = new City() { Id =model.Id,Name= model.name };
            return city;
        }
        #endregion
    }
}
