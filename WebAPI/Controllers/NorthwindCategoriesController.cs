using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NorthwindCategoriesController : ControllerBase
    {
        INorthwindCategoryService _northwindCategoryService;

        public NorthwindCategoriesController(INorthwindCategoryService northwindCategoryService)
        {
            _northwindCategoryService = northwindCategoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _northwindCategoryService.GetAll();
            if (result.Success)
            {
                return Ok(_northwindCategoryService.GetAll());
            }
            return BadRequest();
        }
    }
}
