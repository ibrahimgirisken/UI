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
    public class NorthwindProductsController : ControllerBase
    {
        INorthwindProductService _northwindAttributeService;

        public NorthwindProductsController(INorthwindProductService northwindAttributeService)
        {
            _northwindAttributeService = northwindAttributeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _northwindAttributeService.GetAll();
            if (result.Success)
            {
                return Ok(_northwindAttributeService.GetAll());
            }
            return BadRequest();
        }

        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _northwindAttributeService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(_northwindAttributeService.GetAllByCategoryId(categoryId));
            }
            return BadRequest();
        }
    }
}
