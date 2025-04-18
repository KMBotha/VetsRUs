﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetsAPI.Data;

#nullable disable

namespace VetsAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext.ApplicationDbConnect))]
    [Migration("20250410075149_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VetsAPI.Models.Cat", b =>
                {
                    b.Property<int>("CatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Conditions")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OwnerNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("CatID");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatID = 1,
                            Age = 2,
                            Breed = "Domestic Shorthair",
                            Conditions = "Healthy",
                            Name = "Fluffy",
                            OwnerName = "John",
                            OwnerNumber = "0821234567",
                            Weight = 6
                        },
                        new
                        {
                            CatID = 2,
                            Age = 5,
                            Breed = "Ragdoll",
                            Conditions = "Diabetes",
                            Name = "Snowball",
                            OwnerName = "Emily",
                            OwnerNumber = "0721234567",
                            Weight = 10
                        },
                        new
                        {
                            CatID = 3,
                            Age = 1,
                            Breed = "Russian Blue",
                            Conditions = "Malnourished",
                            Name = "Hercules",
                            OwnerName = "Aldron",
                            OwnerNumber = "0824567893",
                            Weight = 5
                        });
                });

            modelBuilder.Entity("VetsAPI.Models.Dog", b =>
                {
                    b.Property<int>("DogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DogID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Conditions")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OwnerNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("DogID");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogID = 1,
                            Age = 2,
                            Breed = "Husky",
                            Conditions = "Healthy",
                            Name = "Jasper",
                            OwnerName = "Liam",
                            OwnerNumber = "0821284567",
                            Weight = 10
                        },
                        new
                        {
                            DogID = 2,
                            Age = 10,
                            Breed = "Boerbull",
                            Conditions = "Healthy - Elderly",
                            Name = "Bruno",
                            OwnerName = "Luke",
                            OwnerNumber = "0735849612",
                            Weight = 9
                        },
                        new
                        {
                            DogID = 3,
                            Age = 5,
                            Breed = "Jack Russel",
                            Conditions = "Healthy",
                            Name = "Billy",
                            OwnerName = "Alex",
                            OwnerNumber = "0824569693",
                            Weight = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
