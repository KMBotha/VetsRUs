using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetsAPI.Models;

namespace VetsAPI.Data.Config
{
    public class CatConfiguration : IEntityTypeConfiguration<Cat>
    {
        public void Configure(EntityTypeBuilder<Cat> builder)
        {
            builder.HasKey(a => a.CatID);

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.OwnerNumber)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.OwnerNumber)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Breed)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Conditions)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Age)
                .IsRequired();

            builder.Property(a => a.Weight)
                .IsRequired();

            builder.HasData(
                new Cat
                {
                    CatID = 1,
                    Name = "Fluffy",
                    Breed = "Domestic Shorthair",
                    OwnerName = "John",
                    OwnerNumber = "0821234567",
                    Age = 2,
                    Weight = 6,
                    Conditions = "Healthy"
                },
                new Cat
                {
                    CatID = 2,
                    Name = "Snowball",
                    Breed = "Ragdoll",
                    OwnerName = "Emily",
                    OwnerNumber = "0721234567",
                    Age = 5,
                    Weight = 10,
                    Conditions = "Diabetes"
                },
                new Cat
                {
                    CatID = 3,
                    Name = "Hercules",
                    Breed = "Russian Blue",
                    OwnerName = "Aldron",
                    OwnerNumber = "0824567893",
                    Age = 1,
                    Weight = 5,
                    Conditions = "Malnourished"
                }
            );
        }
    }
}
