using DataAccess.Abstracts;
using Entitiess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BrandDal : IBrandDal
    {
        List<Brand> brands;
        public BrandDal()
        {
            brands = new List<Brand>();
            brands.Add(new Brand{ Id=1, Name = "BMV", CreatedData = DateTime.Now });
            brands.Add(new Brand { Id = 2, Name = "TOROS", CreatedData = DateTime.Now });
            brands.Add(new Brand { Id = 3, Name = "Mercedes", CreatedData = DateTime.Now });
            brands.Add(new Brand { Id = 4, Name = "DESLA", CreatedData = DateTime.Now });
        }
        public void Add(Brand brand)
        {
            brands.Add((Brand)brand);
        }

        public List<Brand> GetAll()
        {
            return brands;
        }
    }
}
