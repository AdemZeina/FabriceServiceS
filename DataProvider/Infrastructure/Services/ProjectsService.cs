using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataProvider.Infrastructure.Entity;
using DataProvider.Infrastructure.Seeder;

namespace DataProvider.Infrastructure.Services
{
    public class ProjectsService: IProjectsService
    {
        public List<Projects> GetProjectListByCountryId(int countryId)
        {
            return DataJsonSeeder.LoadData.Where(x => x.Country.Id == countryId).OrderByDescending(y => y.Id).ToList();
        }
    }
}
