using Entities.Concrete;
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
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<BebejiProduct> Get()
        {
            return new List<BebejiProduct>
            {
                new BebejiProduct{Id=1,ProductName="Elma"},
                new BebejiProduct{Id=2,ProductName="Armut"},
                new BebejiProduct{Id=2,ProductName="Karpuz"}
            };
        }
    }
}
