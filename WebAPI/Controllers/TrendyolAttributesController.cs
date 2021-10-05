using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.Trendyol;
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
    public class TrendyolAttributesController : ControllerBase
    {
        ITrendyolAttributeService _trendyolAttributeService;
        public TrendyolAttributesController(ITrendyolAttributeService trendyolAttributeService)
        {
            this._trendyolAttributeService = trendyolAttributeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
         return Ok(_trendyolAttributeService.GetAll());
            //if (result.Success)
            //{
            //    return Ok(result);
            //}
            //return BadRequest(result);
        }

        [HttpPost]
        public IActionResult AttributeAdd(TrendyolAttribute trendyolAttribute)
        {
           var result= _trendyolAttributeService.Add(trendyolAttribute);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }
    }
}
