using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WizarDSoftwareHRM.Shared;

namespace WizarDSoftwareHRM.Application.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
