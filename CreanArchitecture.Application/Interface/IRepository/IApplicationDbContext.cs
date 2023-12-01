using CreanArchitecture.Domain.Entyties;
using Microsoft.EntityFrameworkCore;

namespace CreanArchitecture.Application.Interface.IRepository
{
    public interface IApplicationDbContext
    {
        DbSet<Student> Students { get; set; }
        Task<bool> SaveAsync();
    }
}
