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
    public class YeditepeCategoriesController : ControllerBase
    {
        IYeditepeCategoryService _yeditepeCategoryService;

        public YeditepeCategoriesController(IYeditepeCategoryService yeditepeCategoryService)
        {
            _yeditepeCategoryService = yeditepeCategoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _yeditepeCategoryService.getAll();
            if (result.Success)
            {
                return Ok(_yeditepeCategoryService.getAll());
            }
            return BadRequest();
        }
    }
}
