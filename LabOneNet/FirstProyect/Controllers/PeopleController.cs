using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {

        [HttpGet("all")]
        public List<People> GetPeople() => Repository.People;
        [HttpGet("{id}")]
        public People GetPeopleById(int id) => Repository.People.First(p => p.Id == id);

        [HttpGet("search/{search}")]
        public List<People> GetPeoplesByName(string search) => Repository.People.Where(s => s.Name.ToUpper().Contains(search.ToUpper())).ToList();




    }







    public class Repository {


        public static List<People> People = new List<People>()
        {

            new People(){

                Id = 1,
                Name = "Estevan",
                Birthdate = new DateTime(1998,7,6)

            },

            new People(){

                Id = 2,
                Name = "Santiago",
                Birthdate = new DateTime(1996,11,13)
               
            },

            new People(){

                Id = 3,
                Name = "Melany",
                Birthdate = new DateTime(2002,8,28)

            },

        };
    }


    public class People { 
    
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

    
    
    }
}
