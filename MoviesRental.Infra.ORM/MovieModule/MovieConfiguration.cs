using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesRental.Domain.MovieModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Infra.ORM.MovieModule
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("MovieDB");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).HasColumnType("NVARCHAR(60)");
            builder.Property(p => p.Category).HasColumnType("NVARCHAR(100)");
            builder.Property(p => p.Classification).HasColumnType("NVARCHAR(50)");
            builder.Property(p => p.ReleaseDate).HasColumnType("DATE");
        }
    }
}
