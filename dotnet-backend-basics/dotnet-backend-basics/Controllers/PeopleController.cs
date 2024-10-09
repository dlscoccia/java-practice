using dotnet_backend_basics.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_backend_basics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService) { 
            _peopleService = peopleService;
        }

        [HttpGet("all")]
        public List<People> GetPeople() => Repository.People;

        [HttpGet("{id}")]
        public ActionResult<People> Get(int id)
        {
         var people =   Repository.People.FirstOrDefault(p => p.Id == id);

            if (people == null) { 
            return NotFound();
            }

            return Ok(people);
        }
        [HttpGet("search/{search}")]
        public List<People> Get(string search) => Repository.People.Where(p => p.Name.ToUpper().Contains(search.ToUpper())).ToList();

        [HttpPost]
        public IActionResult Add(People people)
        {
            Console.WriteLine(people);
            if (_peopleService.Validate(people))
            {
                return BadRequest();
            }

            Repository.People.Add(people);

            return NoContent();
        }
    }

    public class Repository
    {
        public static List<People> People = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Fonzi 1",
                Birthdate = DateTime.Now,
            },
            new People()
            {
                Id = 2,
                Name = "Fonzi 2",
                Birthdate = DateTime.Now,
            },
            new People()
            {
                Id = 3,
                Name = "Fonzi 3",
                Birthdate = DateTime.Now,
            },
            new People()
            {
                Id = 4,
                Name = "Fonzi 4",
                Birthdate = DateTime.Now,
            }
        };  
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
