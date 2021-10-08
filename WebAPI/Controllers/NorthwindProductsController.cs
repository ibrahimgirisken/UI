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
        [HttpGet]
        public IActionResult GetAll()
        {
            Thread.Sleep(5000);
            return Ok(_northwindAttributeService.GetAll());
        }
    }
}
