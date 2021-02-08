using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WizarDSoftwareHRM.Shared;

namespace WizarDSoftwareHRM.Application.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}

