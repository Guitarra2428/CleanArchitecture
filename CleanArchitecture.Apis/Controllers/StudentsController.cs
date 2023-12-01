using CreanArchitecture.Application.Feacture.StudentFeacture.Commands.CreateStudent;
using CreanArchitecture.Application.Feacture.StudentFeacture.Queries.GetAllStudent;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentGetAllQuery _query;
        public StudentsController(IStudentGetAllQuery query)
        {
             _query = query;
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _query.Execute(); // Ejecutar la consulta y obtener el resultado

            if (result != null)
            {
                // Suponiendo que result es una lista de objetos StudentQueryDto,
                // podrías devolver Ok con los datos obtenidos.
                return Ok(result);
            }
            else
            {
                // Manejar otro caso si result es null o no se puede convertir a IActionResult.
                return NotFound(); // O podrías devolver BadRequest() u otro resultado según sea necesario.
            }
        }


        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentsController>
        [HttpPost]
        public  IActionResult Post([FromBody] StudentDto dto, [FromServices] CreateStudentCommand command)
        {
            command.Execute(dto);
            return Ok();
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
