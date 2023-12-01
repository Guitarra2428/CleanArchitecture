using AutoMapper;
using CreanArchitecture.Application.Interface.IRepository;
using CreanArchitecture.Application.Interface.IRepository.StudentInterface;
using CreanArchitecture.Domain.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanArchitecture.Application.Feacture.StudentFeacture.Commands.DeleteStudent
{
    public class DeleteStudentCommand: IDeleteStudentCommand
    {
       
        private readonly IStudentRepository _studentRepository;
       
       
       public DeleteStudentCommand(IStudentRepository repository)
        {          
            _studentRepository = repository;              
        }

        public async Task<bool> Execute(int Id)
        {
           return await _studentRepository.DeleteAsync(Id);           
        }
    }
}
