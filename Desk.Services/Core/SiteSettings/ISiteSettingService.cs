using Desk.Core.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Core.SiteSettings
{
    public interface ISiteSettingService
    {
        Task<IEnumerable<SiteSetting>> GetAllAsync();
        Task<SiteSetting> AddAsync(SiteSetting model);
        Task<bool> UpdateAsync(SiteSetting model);
        Task<SiteSetting> FirstOrDefaultAsync();
    }
}
