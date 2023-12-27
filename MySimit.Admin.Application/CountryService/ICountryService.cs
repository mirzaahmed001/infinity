using MySimit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimit.Admin.Application.CountryService
{
    public interface ICountryService
    {
        public void AddAsync(Country country);
        public int Delete(int countryId);
        public Task<Country?> GetByID(int countryId);
        public Task<List<Country>> GetAllAsync();
    }
}
