using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet]
        public decimal Get(decimal a, decimal b)
        {
            return a + b;
        }

        [HttpPost]
        public decimal Add(decimal a, decimal b, [FromHeader] string Host,
         [FromHeader(Name ="X-Some")] string CustomHeader) 
        {
            Console.WriteLine(Host);
            Console.WriteLine(CustomHeader);
            return a + b; 
        }



    }
}
