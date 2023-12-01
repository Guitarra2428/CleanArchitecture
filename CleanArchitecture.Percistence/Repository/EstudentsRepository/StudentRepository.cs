using CreanArchitecture.Application.Interface.IRepository;
using CreanArchitecture.Application.Interface.IRepository.StudentInterface;
using CreanArchitecture.Domain.Entyties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Percistence.Repository.EstudentsRepository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public StudentRepository( IApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }
      

        public async Task AddAsync(Student student)
        {
          await  _applicationDbContext.Students.AddAsync(student);
        }

      
        public async Task DeleteAsync(int id)
        {
            var delete = await _applicationDbContext.Students.FindAsync(id);
            if (delete != null)
            {
                 _applicationDbContext.Students.Remove(delete);
                await _applicationDbContext.SaveAsync();
            }
                      
        }


        public async Task<ICollection<Student>> GetAllAsync()
        {
            return await _applicationDbContext.Students.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Student> GetAsync(int id)
        {
            return await _applicationDbContext.Students.FirstOrDefaultAsync(x => x.Id == id);

        }


        public async Task<Student> GetByNameAsync(string name)
        {
            return await _applicationDbContext.Students.FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task UpdateAsync(Student student)
        {
            _applicationDbContext.Students.Update(student);
        }
    }
}
