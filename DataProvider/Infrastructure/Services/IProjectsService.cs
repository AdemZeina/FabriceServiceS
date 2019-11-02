using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataProvider.Infrastructure.Entity;

namespace DataProvider.Infrastructure.Services
{
    public interface IProjectsService
    {
        List<Projects> GetProjectListByCountryId(int countryId);
    }
}
