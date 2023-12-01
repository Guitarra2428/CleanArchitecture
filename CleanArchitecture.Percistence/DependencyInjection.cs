using CleanArchitecture.Percistence.DbContexts;
using CleanArchitecture.Percistence.Repository.EstudentsRepository;
using CreanArchitecture.Application.Interface.IRepository;
using CreanArchitecture.Application.Interface.IRepository.StudentInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Percistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPercistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase(databaseName:"SudentClenArchictecture"));
            services.AddDbContext<IApplicationDbContext, ApplicationDbContext>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
