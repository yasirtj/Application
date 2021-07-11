using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Context
{
    public interface IStudentDbContext 
    {
        public DbSet<Entity.Student> Student { get; set; }
        public DbSet<T> Set<T>() where T : class;
        void Save();
    }
    public class StudentDbContext : DbContext , IStudentDbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
        public DbSet<Entity.Student> Student { get; set; }
        public DbSet<Entity.Subject> Subject { get; set; }
        public DbSet<Entity.StudentGrade> StudentGrade { get; set; }

        public void Save()
        {
            SaveChanges();
        }
    }
}
