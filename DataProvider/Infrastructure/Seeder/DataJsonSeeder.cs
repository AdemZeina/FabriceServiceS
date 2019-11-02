using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataProvider.Infrastructure.Entity;

namespace DataProvider.Infrastructure.Seeder
{
    public static class DataJsonSeeder
    {
        public static List<Country> Countries=new List<Country>()
        {
            new Country(){Id = 1,Name = "Turkey",CreateDate = DateTime.Now},
            new Country(){Id = 2,Name = "Germany",CreateDate = DateTime.Now},
            new Country(){Id = 3,Name = "Syria",CreateDate = DateTime.Now},
        };

        public static List<Customer> Customers = new List<Customer>()
        {
            new Customer(){Id = 1,CustomerName = "Adem",CreateDate = DateTime.Now},
            new Customer(){Id = 2,CustomerName = "Mohamad",CreateDate = DateTime.Now},
            new Customer(){Id = 3,CustomerName = "Ahmad",CreateDate = DateTime.Now},
        };

        public static List<Projects> LoadData = new List<Projects>()
        {
            new Projects(){Id=1,ProjectName = ".Net Web Project",Country = GetCountryById(1),Customer = GetCustomerById(3),CreateDate = DateTime.Now},
            new Projects(){Id=2,ProjectName = "Java Projects",Country = GetCountryById(1),Customer = GetCustomerById(2),CreateDate = DateTime.Now},
            new Projects(){Id=3,ProjectName = "Mobile Projects",Country = GetCountryById(1),Customer = GetCustomerById(1),CreateDate = DateTime.Now},
            new Projects(){Id=4,ProjectName = ".Net Web Project",Country = GetCountryById(2),Customer = GetCustomerById(1),CreateDate = DateTime.Now},
            new Projects(){Id=5,ProjectName = ".Net Web Project",Country = GetCountryById(3),Customer = GetCustomerById(2),CreateDate = DateTime.Now},

        };


        public static Customer GetCustomerById(int id)
        {
            return Customers.Find(x=>x.Id==id);
        }

        public static Country GetCountryById(int id)
        {
            return Countries.Find(x => x.Id == id);
        }
    }
}
