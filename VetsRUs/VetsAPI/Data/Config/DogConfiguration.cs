using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VetsAPI.Models;

namespace VetsAPI.Data.Config
{
    public class DogConfiguration : IEntityTypeConfiguration<Dog>
    {
        public void Configure(EntityTypeBuilder<Dog> builder)
        {
            builder.HasKey(a => a.DogID);

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
                new Dog
                {
                    DogID = 1,
                    Name = "Jasper",
                    Breed = "Husky",
                    OwnerName = "Liam",
                    OwnerNumber = "0821284567",
                    Age = 2,
                    Weight = 10,
                    Conditions = "Healthy"
                },
                new Dog
                {
                    DogID = 2,
                    Name = "Bruno",
                    Breed = "Boerbull",
                    OwnerName = "Luke",
                    OwnerNumber = "0735849612",
                    Age = 10,
                    Weight = 9,
                    Conditions = "Healthy - Elderly"
                },
                new Dog
                {
                    DogID = 3,
                    Name = "Billy",
                    Breed = "Jack Russel",
                    OwnerName = "Alex",
                    OwnerNumber = "0824569693",
                    Age = 5,
                    Weight = 6,
                    Conditions = "Healthy"
                }
            );
        }
    }
}
