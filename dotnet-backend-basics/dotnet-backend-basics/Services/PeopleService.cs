using dotnet_backend_basics.Controllers;

namespace dotnet_backend_basics.Services
{
    public class PeopleService : IPeopleService
    {
        public bool Validate(People people)
        {
            Console.WriteLine(people);
            if (string.IsNullOrEmpty(people.Name)) {
                return false;
            }
            return true;
        }
    }
}
