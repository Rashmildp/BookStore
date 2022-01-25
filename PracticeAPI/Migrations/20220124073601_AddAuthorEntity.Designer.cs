﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracticeAPI.DataAceess;

namespace PracticeAPI.Migrations
{
    [DbContext(typeof(BookdbContext))]
    [Migration("20220124073601_AddAuthorEntity")]
    partial class AddAuthorEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "England",
                            FirstName = "J. K.",
                            LastName = "Rowling"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Ireland",
                            FirstName = "Jonathan",
                            LastName = "Swift"
                        },
                        new
                        {
                            Id = 3,
                            Country = "England",
                            FirstName = "Daniel",
                            LastName = "Defoe"
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

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

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

            modelBuilder.Entity("PracticeAPI.Models.Book", b =>
                {
                    b.HasOne("PracticeAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}