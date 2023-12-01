using AutoMapper;
using CreanArchitecture.Application.Feacture.StudentFeacture.Commands.CreateStudent;
using CreanArchitecture.Application.Feacture.StudentFeacture.Queries.GetAllStudent;
using CreanArchitecture.Application.Interface.IRepository;
using CreanArchitecture.Application.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanArchitecture.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());

            });

            services.AddSingleton(mapper.CreateMapper());
             services.AddTransient<CreateStudentCommand>();
           //  services.AddTransient<StudentGetAllQuery>();
            services.AddScoped<IStudentGetAllQuery, StudentGetAllQuery>();        
            // services.AddTransient<ICreateStudentCommand, CreateStudentCommand>();
            return services;
        }
    }
}

