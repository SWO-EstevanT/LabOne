using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstevanController : ControllerBase
    {


        [HttpGet]
        public decimal Get(decimal a, decimal b)
        {
            return a * b;
        }








    }
}
