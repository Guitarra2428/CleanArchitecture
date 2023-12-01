using CreanArchitecture.Application.Feacture.StudentFeacture.Commands.CreateStudent;
using CreanArchitecture.Application.Feacture.StudentFeacture.Commands.DeleteStudent;
using CreanArchitecture.Application.Feacture.StudentFeacture.Commands.UpdateStudent;
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
    private readonly ICreateStudentCommand _createStudentCommand;
    private readonly IUpdateStudentCommand _updateStudentCommand;
    private readonly IDeleteStudentCommand _deleteStudentCommand;

    public StudentsController(
        IStudentGetAllQuery query,
        ICreateStudentCommand createStudentCommand,
        IUpdateStudentCommand updateStudentCommand,
        IDeleteStudentCommand deleteStudentCommand)
    {
        _query = query;
        _createStudentCommand = createStudentCommand;
        _updateStudentCommand = updateStudentCommand;
        _deleteStudentCommand = deleteStudentCommand;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var result = _query.Execute();

        if (result != null)
        {
            return Ok(result);
        }
        else
        {

            return NotFound();
        }
    }

    [HttpPost]
    public IActionResult CreateStudent([FromBody] StudentDto dto)
    {
        var created = _createStudentCommand.Execute(dto);
        if (created != null)
        {
            return  Ok();
        }
        return BadRequest();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateStudent(int id, [FromBody] UpdateStudentDto dto)
    {
        var updated = _updateStudentCommand.Execute(dto);
        if (updated != null)
        {
            return Ok(updated);
        }
        return NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStudent(int id)
    {
        var deleted = _deleteStudentCommand.Execute(id);
        if (deleted !=null)
        {
            return NoContent();
        }
        return NotFound();
    }

 
}
}

