using Business.Dtos.Request;
using Business.Dtos.Response;
using Entitiess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        public CreateBrandResponse Add(CreateBrandRequest brand);

        List<GetAllBrandResponse> GetAll();
    }
}