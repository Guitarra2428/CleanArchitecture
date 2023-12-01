using CreanArchitecture.Domain.Entyties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Percistence.Configuration.EntytiesConfiguracion.StudentConfiguracions
{
    public class StudentConfiguracion
    {
        public StudentConfiguracion(EntityTypeBuilder<Student> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Name).IsRequired();
            entityTypeBuilder.Property(e=>e.Age).IsRequired();
        }
    }
}
