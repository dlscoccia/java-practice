using dotnet_backend_basics.Controllers;

namespace dotnet_backend_basics.Services
{
    public interface IPeopleService
    {
        bool Validate(People people);
    }
}
