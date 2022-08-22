using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesRental.Domain.EmployeeModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Infra.ORM.EmployeeModule
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("EmployeeDB");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Email).HasColumnType("NVARCHAR(60)");
            builder.Property(p => p.Name).HasColumnType("NVARCHAR(50)");
            builder.Property(p => p.Password).HasColumnType("NVARCHAR(100)");
            builder.Property(p => p.AccessKey).HasColumnType("NVARCHAR(50)");
        }
    }
}
