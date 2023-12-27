using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySimit.Domain.Entities;

namespace MySimit.Admin.Application.Interface
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
        IRepository<Country> CountryRepository { get; }
    }
}
