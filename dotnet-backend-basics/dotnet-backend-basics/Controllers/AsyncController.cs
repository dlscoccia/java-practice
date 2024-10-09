using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_backend_basics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsyncController : ControllerBase
    {
        [HttpGet("sync")]
        public IActionResult Sync() {

            Thread.Sleep(1000);

        return Ok();
        }

        [HttpGet("async")]
        public async Task<IActionResult> GetAsync() {
            var task1 = new Task<int>(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Conexión a DB");
                return 8;
            });

            task1.Start();

            Console.WriteLine("Trajando!");

            var result = await task1;

            Console.WriteLine("Terminado");


            return Ok(result);
        }

    
    }


}
