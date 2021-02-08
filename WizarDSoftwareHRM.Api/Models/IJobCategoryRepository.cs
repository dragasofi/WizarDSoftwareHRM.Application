using System.Collections.Generic;
using WizarDSoftwareHRM.Shared;

namespace WizarDSoftwareHRM.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
