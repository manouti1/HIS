using Domain;
using Domain.Mapping;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new PatientMap(modelBuilder.Entity<Patient>());
            new GuardianMap(modelBuilder.Entity<Guardian>());
        }
    }
}
