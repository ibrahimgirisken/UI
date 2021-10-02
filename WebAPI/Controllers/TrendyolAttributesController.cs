using Business.Abstract;
using Business.Concrete;
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
        public List<TrendyolAttribute> Get()
        {
            return _trendyolAttributeService.GetAll();
        }
    }
}
