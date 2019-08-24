using Microsoft.EntityFrameworkCore;
using System;

namespace UStudentAPI.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 1,
                FirstName = "Margarit",
                LastName = "Safaryan",
                University = "NPUA",
                City = "Yerevan",
                Country = "Armenia"

            }, new Student
            {
                StudentId = 2,
                FirstName = "Will",
                LastName = "Smith",
                University = "MIT",
                City = "Cambridge",
                Country = "USA"
            });
        }
    }
}
