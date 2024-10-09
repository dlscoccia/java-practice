using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_backend_basics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet]
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        [HttpPost]
        public decimal Remove(decimal a, decimal b)
        {
            return a - b;
        }
    }
}
