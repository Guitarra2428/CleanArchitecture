using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanArchitecture.Application.Feacture.StudentFeacture.Commands.UpdateStudent
{
    public interface IUpdateStudentCommand
    {
        Task<UpdateStudentDto> Execute(UpdateStudentDto model);
    }
}
