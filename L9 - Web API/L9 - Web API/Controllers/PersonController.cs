using Microsoft.AspNetCore.Mvc;

namespace L9___Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private static readonly List<Person> people = [
            new Person { Id = 1, Name = "Person1", Age = 20 },
            new Person { Id = 2, Name = "Person2", Age = 30 },
            new Person { Id = 3, Name = "Person3", Age = 40 },
            new Person { Id = 4, Name = "Person4", Age = 50 },
            new Person { Id = 5, Name = "Person5", Age = 60 }
        ];

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPersoner")]
        public IEnumerable<Person> Get()
        {
            return people;
        }

        [HttpGet("{id}", Name = "GetPersonById")]
        public Person Get(int id)
        {
            return people.Find(p => p.Id == id) ?? new Person { Id = -1 };
        }

        [HttpPost]
        public void AddPerson(Person person)
        {
            people.Add(person);
        }
    }
}
