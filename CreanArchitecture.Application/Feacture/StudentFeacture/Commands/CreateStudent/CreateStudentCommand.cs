using AutoMapper;
using CreanArchitecture.Application.Interface.IRepository;
using CreanArchitecture.Application.Interface.IRepository.StudentInterface;
using CreanArchitecture.Domain.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanArchitecture.Application.Feacture.StudentFeacture.Commands.CreateStudent
{
    public class CreateStudentCommand: ICreateStudentCommand
    {
        private readonly IApplicationDbContext _context;
       private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public CreateStudentCommand(IApplicationDbContext context, IMapper mapper, IStudentRepository studentRepository)
        {
            _context = context;

            _mapper = mapper;
            _studentRepository = studentRepository;
        }


        public async Task<StudentDto> Execute(StudentDto model)
        {
            var mapper= _mapper.Map<Student>(model);
            await _studentRepository.AddAsync(mapper);            
            await _context.SaveAsync();
            return model;
        }
    }
}
