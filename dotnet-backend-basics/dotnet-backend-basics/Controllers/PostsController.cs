using dotnet_backend_basics.DTOs;
using dotnet_backend_basics.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_backend_basics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        IPostsService _titlesService;

        public PostsController(IPostsService titleService)
        {
            _titlesService = titleService;
        }

        [HttpGet]
        public async Task<IEnumerable<PostDto>> Get() => await _titlesService.Get();
    }
}
