using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanArchitecture.Application.Feacture.StudentFeacture.Commands.CreateStudent
{
    public  interface ICreateStudentCommand
    {
        Task<StudentDto> Execute(StudentDto model);
        
    }
}
