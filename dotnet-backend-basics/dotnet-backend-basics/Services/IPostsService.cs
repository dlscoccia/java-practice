using dotnet_backend_basics.DTOs;

namespace dotnet_backend_basics.Services
{
    public interface IPostsService
    {
        public Task<IEnumerable<PostDto>> Get();
    }
}
