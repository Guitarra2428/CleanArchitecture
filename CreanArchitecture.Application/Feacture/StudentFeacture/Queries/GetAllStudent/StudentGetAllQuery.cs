using AutoMapper;
using CreanArchitecture.Application.Interface;
using CreanArchitecture.Application.Interface.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanArchitecture.Application.Feacture.StudentFeacture.Queries.GetAllStudent
{
    public class StudentGetAllQuery: IStudentGetAllQuery
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
       // private readonly IGenericRepository _repository;

        public StudentGetAllQuery( IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<StudentQueryDto>> Execute()
        {
            var entity=  await _context.Students.ToListAsync();
            return   _mapper.Map<List<StudentQueryDto>>(entity);
        }
    }
}
