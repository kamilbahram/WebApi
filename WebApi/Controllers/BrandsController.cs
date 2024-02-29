using Business.Abstracts;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
            CreateBrandResponse createBrandResponse = _brandService.Add(createBrandRequest);
            return Ok(createBrandResponse);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_brandService.GetAll());
        }
    }
}
