using Desk.Core.Common;
using Desk.Core.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Services.Enums
{
   public  interface IApplicationStatusService
    {
        Dictionary<int, string> GetAvailableProviderTypes(int[] valuesToExclude = null, bool useLocalization = false);
        IEnumerable<SelectListItem> SelectListItems();
        string GetName(int id);
    }
    public class ApplicationStatusService : IApplicationStatusService
    {
        public string GetName(int id)
        {
            return Enum.GetName(typeof(ApplicationStatus), id);
        }

        public Dictionary<int, string> GetAvailableProviderTypes(int[] valuesToExclude = null, bool useLocalization = true)
        {
            return Enum.GetValues(typeof(ApplicationStatus))
                .Cast<ApplicationStatus>()
                .ToDictionary(
                    enumValue => Convert.ToInt32(enumValue),
                    enumValue => CommonHelper.ConvertEnum(enumValue.ToString()));
        }

        public IEnumerable<SelectListItem> SelectListItems()
        {
            return GetAvailableProviderTypes()
                .OrderBy(v => v.Value)
                .Select(pt => new SelectListItem
                {
                    Value = pt.Key.ToString(),
                    Text = pt.Value
                });
        }

        public List<SelectListItem> SelectLists { get; set; }
    }

}
