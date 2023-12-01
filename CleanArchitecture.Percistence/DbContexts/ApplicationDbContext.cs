using CleanArchitecture.Percistence.Configuration.EntytiesConfiguracion.StudentConfiguracions;
using CreanArchitecture.Application.Interface.IRepository;
using CreanArchitecture.Domain.Entyties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Percistence.DbContexts
{
    public class ApplicationDbContext: DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
                
        }

        public  DbSet<Student> Students { get; set; }
     
        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguracion(modelBuilder);
        }

        private void EntityConfiguracion( ModelBuilder modelBuilder )
        {
            new StudentConfiguracion(modelBuilder.Entity<Student>());
        }
        
        public async Task<bool> SaveAsync()
        {
            return  await SaveChangesAsync()>0;
        } 
    }
}
