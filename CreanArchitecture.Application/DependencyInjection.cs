using AutoMapper;
using CreanArchitecture.Application.Feacture.StudentFeacture.Commands.CreateStudent;
using CreanArchitecture.Application.Feacture.StudentFeacture.Commands.DeleteStudent;
using CreanArchitecture.Application.Feacture.StudentFeacture.Commands.UpdateStudent;
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
             services.AddTransient<IDeleteStudentCommand, DeleteStudentCommand>();
         
            services.AddTransient<IStudentGetAllQuery, StudentGetAllQuery>();
            services.AddTransient< IUpdateStudentCommand , UpdateStudentCommand > ();
            
           services.AddTransient<ICreateStudentCommand, CreateStudentCommand>();
            return services;
        }
    }
}

