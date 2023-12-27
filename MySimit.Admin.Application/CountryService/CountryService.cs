
using MySimit.Domain.Entities;
using MySimit.Admin.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimit.Admin.Application.CountryService
{
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Country> _countryRepository;
        public CountryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _countryRepository = _unitOfWork.CountryRepository;
        }
        public void AddAsync(Country country)
        {
            _countryRepository.Add(country);
            _unitOfWork.Commit();
        }
    

        public int Delete(int id)
        {
        var numberOfRow =  _countryRepository.Delete(id);
        if (numberOfRow < 0)
        {
            _unitOfWork.Commit();
        }
        return numberOfRow;
    }

        public Task<List<Country>> GetAllAsync()
        {
            return _countryRepository.GetAll();
        }

        public Task<Country?> GetByID(int countryId)
        {
            return _countryRepository.GetById(countryId);
        }

        
    }
}
