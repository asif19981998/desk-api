using Desk.Core.Domain.Employees;
using Desk.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Desk.Services.Employees.TrainingInformaitons
{
    public interface ITrainingInformaitonService
    {

        Task<IEnumerable<TrainingInformation>> GetAllAsync();
        Task<IEnumerable<TrainingInformation>> GetAllDeletedAsync();
        Task<TrainingInformation> GetByIdAsync(long id);
        Task<TrainingInformation> AddAsync(TrainingInformation model);
        Task<bool> UpdateAsync(TrainingInformation model);
        Task<bool> SoftDeleteAsync(TrainingInformation model);
        Task<bool> RestoreAsync(TrainingInformation model);
        Task<bool> RestoreByIdAsync(long id);
        Task<bool> RestoreByIdsAsync(List<long> ids);
        Task<bool> PermanentDeleteAsync(TrainingInformation model);
        Task<bool> PermanentDeleteByIdAsync(long id);
        Task<bool> SoftDeleteByIdAsync(long id);
        int TotalCount();
        Task<PagedModel<TrainingInformation>> GetPagedListAsync(int page, int pageSize);
        Task<PagedModel<TrainingInformation>> GetDeletedPagedAsync(int page, int pageSize);
    }
}
