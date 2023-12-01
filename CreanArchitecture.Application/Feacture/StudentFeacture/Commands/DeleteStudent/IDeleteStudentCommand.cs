using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanArchitecture.Application.Feacture.StudentFeacture.Commands.DeleteStudent
{
    public interface IDeleteStudentCommand
    {
        Task<bool> Execute(int Id);
    }
}
