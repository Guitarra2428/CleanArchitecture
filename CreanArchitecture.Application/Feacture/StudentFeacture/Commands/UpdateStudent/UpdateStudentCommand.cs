using AutoMapper;
using CreanArchitecture.Application.Interface.IRepository.StudentInterface;
using CreanArchitecture.Application.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreanArchitecture.Domain.Entyties;

namespace CreanArchitecture.Application.Feacture.StudentFeacture.Commands.UpdateStudent
{
    public class UpdateStudentCommand: IUpdateStudentCommand
    {
        private readonly IApplicationDbContext _context;
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public UpdateStudentCommand(IApplicationDbContext context, IStudentRepository studentRepository, IMapper mapper)
        {
            _context = context;
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<UpdateStudentDto> Execute(UpdateStudentDto model)
        {
            var entity = _mapper.Map<Student>(model);
            await _studentRepository.UpdateAsync(entity);
           await  _context.SaveAsync();
            return model;
        }
    }
}
