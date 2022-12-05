using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesRental.Domain.ClientModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Infra.ORM.ClientModule
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("ClientDB");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.ClientName).HasMaxLength(70);
            builder.Property(p => p.Telephone).HasColumnType("INT");
            builder.Property(p => p.Address).HasColumnType("NVARCHAR(100)");
            builder.Property(p => p.BornDate).HasColumnType("DATE");
        }
    }
}
