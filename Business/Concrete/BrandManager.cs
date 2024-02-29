using Business.Abstracts;
using Business.Dtos.Request;
using Business.Dtos.Response;
using DataAccess.Abstracts;
using Entitiess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public CreateBrandResponse Add(CreateBrandRequest createBrandRequest)
        {
            //business reles 


            //mapping
            Brand brand = new Brand();
            brand.Name = createBrandRequest.Name;
            _brandDal.Add(brand);

            //mapping
            CreateBrandResponse createBrandResponse = new CreateBrandResponse();
            createBrandResponse.Name = brand.Name;
            createBrandResponse.Id = 5;
            createBrandResponse.CreatedDate = brand.CreatedData;
            
            return createBrandResponse;
        }

        public List<GetAllBrandResponse> GetAll()
        {
            List<Brand> brands = _brandDal.GetAll();
            List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();
            foreach (Brand brand in brands)
            {
                GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
                getAllBrandResponse.Name = brand.Name;
                getAllBrandResponse.Id = brand.Id;
                getAllBrandResponse.CreatedDate = brand.CreatedData;
                getAllBrandResponses.Add(getAllBrandResponse);
            }
            return getAllBrandResponses; 
        }
    }
}
