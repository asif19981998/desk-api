using Desk.Core.Domain.Core;
using Desk.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.SiteSettings
{
    public class SiteSettingService : ISiteSettingService
    {
        private readonly IEntityRepository<SiteSetting> _repository;
        public SiteSettingService(IEntityRepository<SiteSetting> repository)
        {
            _repository = repository;

        }
        public async Task<SiteSetting> AddAsync(SiteSetting model)
        {
            return await _repository.AddAsync(model); 
        }

        public async Task<SiteSetting> FirstOrDefaultAsync()
        {
            return await _repository.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<SiteSetting>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<bool> UpdateAsync(SiteSetting model)
        {
            return await _repository.UpdateAsync(model);
        }
    }
}
