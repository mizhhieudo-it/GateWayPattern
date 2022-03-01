using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] 
            { "Nguyen Van A", 
               "Nguyen Van B" , 
                "Nguyen Van c"
            };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Id Customer - {id}";
        }
        
    }
}
