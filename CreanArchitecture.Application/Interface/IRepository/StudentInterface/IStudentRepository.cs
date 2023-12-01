using CreanArchitecture.Domain.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanArchitecture.Application.Interface.IRepository.StudentInterface
{
    public interface IStudentRepository
    {
        Task<ICollection<Student>> GetAllAsync(); // Obtiene todos los estudiantes de forma asincrónica
        Task<Student> GetAsync(int id); // Obtiene un estudiante por su ID de forma asincrónica
        Task<Student> GetByNameAsync(string name); // Obtiene un estudiante por su nombre de forma asincrónica
        Task AddAsync(Student student); // Agrega un nuevo estudiante de forma asincrónica
        Task UpdateAsync(Student student); // Actualiza la información de un estudiante de forma asincrónica
        Task DeleteAsync(int id); // Elimina un estudiante por su ID de forma asincrónica
    }
}
