using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanArchitecture.Application.Feacture.StudentFeacture.Queries.GetAllStudent
{
    public interface IStudentGetAllQuery
    {
        Task<List<StudentQueryDto>> Execute();
    }
}
