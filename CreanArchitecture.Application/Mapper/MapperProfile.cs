using AutoMapper;
using CreanArchitecture.Application.Feacture.StudentFeacture.Commands.CreateStudent;
using CreanArchitecture.Application.Feacture.StudentFeacture.Queries.GetAllStudent;
using CreanArchitecture.Domain.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanArchitecture.Application.Mapper
{
    public  class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Student , StudentDto>().ReverseMap();
            CreateMap<Student , StudentQueryDto>().ReverseMap();
        }
    }
}
