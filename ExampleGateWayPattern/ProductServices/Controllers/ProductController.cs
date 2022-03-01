using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]
            { "MACBOOK PRO M1",
               "IPHONE 6" ,
                "IPHONE 7",
                "IPHONE 8",
                "IPHONE 9",
                "IPHONE X",
            };
        }
        [HttpGet("get-serviceB")]
        public string ServiceB()
        {
            return $"I From Service B";
        }
    }
}
