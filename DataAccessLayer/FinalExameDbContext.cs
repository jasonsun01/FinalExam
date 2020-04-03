using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using JasonFinalExam.Pocos;

namespace JasonFinalExam.DataAccessLayer
{
    class FinalExameDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CQ091IO\HUMBERBRIDGING;Initial Catalog=WEB_APPLICATION;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasMany(s => s.Enrollments).WithOne(e => e.Student).HasForeignKey(e => e.StudentID);
            modelBuilder.Entity<Course>().HasMany(C => C.Enrollments).WithOne(e => e.Course).HasForeignKey(e => e.CourseID);
            base.OnModelCreating(modelBuilder);
        }
    }
}
