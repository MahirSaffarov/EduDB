using Edu.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Edu.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseImg> CourseImgs { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Student> Students { get; set; }    
        public DbSet<Faculty> Faculties { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Faculty>().HasQueryFilter(m => !m.IsDeleted);



            modelBuilder.Entity<Student>().HasData
            (
            new Student
            {
               Id =1,
               Name = "Mahir",
               Description = "MahirDescription",
               FacultyId = 5,
               Image = "team-1.jpg"
            },
            new Student
            {
                Id = 2,
                Name = "Nicat",
                Description = "MahirDescription",
                FacultyId = 4,
                Image = "team-4.jpg"
            },
            new Student
            {
                Id = 3,
                Name = "Anar",
                Description = "MahirDescription",
                FacultyId = 3,
                Image = "team-2.jpg"
            },
            new Student
            {
                Id = 4,
                Name = "Resul",
                Description = "MahirDescription",
                FacultyId = 2,
                Image = "team-4.jpg"
            },
            new Student
            {
                Id = 5,
                Name = "Fatime",
                Description = "MahirDescription",
                FacultyId = 1,
                Image = "team-3.jpg"
            }
            );
            modelBuilder.Entity<Faculty>().HasData
            (
            new Faculty
            {
                Id = 1,
                Name = "Mahir"
            },
            new Faculty
            {
                Id = 2,
                Name = "Nicat"
            },
            new Faculty
            {
                Id = 3,
                Name = "Anar"
            },
            new Faculty
            {
                Id = 4,
                Name = "Resul"
            },
            new Faculty
            {
                Id = 5,
                Name = "Fatime"
            }
            );
            modelBuilder.Entity<Settings>().HasData(
                new Settings
                {
                    Id = 1,
                    Key = "Logo",
                    Value = "logo.png"
                },
                new Settings
                {
                    Id = 2,
                    Key = "Phone",
                    Value = "+994504198914"
                },
                new Settings
                {
                    Id = 3,
                    Key = "Email",
                    Value = "fiorello@code.edu.az"
                }
            );
        }
    }
}
