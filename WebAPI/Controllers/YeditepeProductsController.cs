using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YeditepeProductsController : ControllerBase
    {
        IYeditepeProductService _yeditepeAttributeService;

        public YeditepeProductsController(IYeditepeProductService yeditepeAttributeService)
        {
            _yeditepeAttributeService = yeditepeAttributeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _yeditepeAttributeService.getAll();
            if (result.Success)
            {
                return Ok(_yeditepeAttributeService.getAll());
            }
            return BadRequest();
        }

        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _yeditepeAttributeService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(_yeditepeAttributeService.GetAllByCategoryId(categoryId));
            }
            return BadRequest();
        }
    }
}
