using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesRental.Domain.RentModule;

namespace MoviesRental.Infra.ORM.RentModule
{
    public class RentConfiguration : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            builder.ToTable("RentDB");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.EmployeeName).HasColumnType("NVARCHAR(60)");
            builder.Property(p => p.MoviesQuantity).HasColumnType("INT");
            builder.Property(p => p.MovieName).HasColumnType("NVARCHAR(200)");
            builder.Property(p => p.ClientName).HasColumnType("NVARCHAR(50)");
            builder.Property(p => p.RentalDate).HasColumnType("DATE");
            builder.Property(p => p.ReturnDate).HasColumnType("DATE");
            builder.Property(p => p.DayValue).HasColumnType("INT");
            builder.Property(p => p.MovieValue).HasColumnType("INT");
            builder.Property(p => p.TotalPrice).HasColumnType("INT");
            builder.Property(p => p.StatusImage).HasColumnType("IMAGE");
            builder.Property(p => p.Status).HasColumnType("NVARCHAR(20)");
        }
    }
}
