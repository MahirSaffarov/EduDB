﻿// <auto-generated />
using System;
using Edu.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Edu.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230608154805_CreateStuFacTable")]
    partial class CreateStuFacTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Edu.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Edu.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Hour")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Edu.Models.CourseImg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsItMain")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseImgs");
                });

            modelBuilder.Entity("Edu.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1845),
                            IsDeleted = false,
                            Name = "Mahir"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1847),
                            IsDeleted = false,
                            Name = "Nicat"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1848),
                            IsDeleted = false,
                            Name = "Anar"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1849),
                            IsDeleted = false,
                            Name = "Resul"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1850),
                            IsDeleted = false,
                            Name = "Fatime"
                        });
                });

            modelBuilder.Entity("Edu.Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Edu.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1668),
                            Description = "MahirDescription",
                            FacultyId = 5,
                            Image = "team-1.jpg",
                            IsDeleted = false,
                            Name = "Mahir"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1683),
                            Description = "MahirDescription",
                            FacultyId = 4,
                            Image = "team-4.jpg",
                            IsDeleted = false,
                            Name = "Nicat"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1685),
                            Description = "MahirDescription",
                            FacultyId = 3,
                            Image = "team-2.jpg",
                            IsDeleted = false,
                            Name = "Anar"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1686),
                            Description = "MahirDescription",
                            FacultyId = 2,
                            Image = "team-4.jpg",
                            IsDeleted = false,
                            Name = "Resul"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1688),
                            Description = "MahirDescription",
                            FacultyId = 1,
                            Image = "team-3.jpg",
                            IsDeleted = false,
                            Name = "Fatime"
                        });
                });

            modelBuilder.Entity("Edu.Models.Course", b =>
                {
                    b.HasOne("Edu.Models.Author", "Author")
                        .WithMany("Courses")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Edu.Models.CourseImg", b =>
                {
                    b.HasOne("Edu.Models.Course", "Course")
                        .WithMany("CourseImgs")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Edu.Models.Student", b =>
                {
                    b.HasOne("Edu.Models.Faculty", "Faculty")
                        .WithMany("Students")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Edu.Models.Author", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Edu.Models.Course", b =>
                {
                    b.Navigation("CourseImgs");
                });

            modelBuilder.Entity("Edu.Models.Faculty", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
