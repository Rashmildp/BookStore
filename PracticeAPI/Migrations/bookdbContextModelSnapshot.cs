﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracticeAPI.DataAceess;

namespace PracticeAPI.Migrations
{
    [DbContext(typeof(BookdbContext))]
    partial class bookdbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PracticeAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "J. K.",
                            country = "England",
                            lastName = "Rowling"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Jonathan",
                            country = "Ireland",
                            lastName = "Swift"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Daniel",
                            country = "England",
                            lastName = "Defoe"
                        });
                });

            modelBuilder.Entity("PracticeAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nOfOpages")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Name = "Harry Potter",
                            nOfOpages = 500,
                            type = "Fantasy"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Name = "Gulliver’s Travels",
                            nOfOpages = 500,
                            type = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Name = " Robinson Crusoe ",
                            nOfOpages = 300,
                            type = "Adventure"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
