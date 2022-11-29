using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class StudentsDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=HP;Database=CodeFirst2;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).HasColumnName("Id").HasColumnType("int").ValueGeneratedOnAdd();
                e.Property(e => e.Username).HasColumnType("NVARCHAR(20)").HasColumnName("username");
                e.Property(e => e.Name).HasColumnName("name").HasColumnType("NVARCHAR(20)");
                e.Property(e => e.Surname).HasColumnType("NVARCHAR(20)").HasColumnName("surname");
                e.Property(e => e.University).HasColumnName("university").HasColumnType("NVARCHAR(20)");
                e.Property(e => e.Grade).HasColumnType("int").HasColumnName("grade");
                e.Property(e => e.TeacherName).HasColumnName("teacher").HasColumnType("NVARCHAR(20)");
            });

            modelBuilder.Entity<Teacher>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();
                e.Property(e => e.TeacherName).HasColumnType("NVARCHAR(20)").HasColumnName("same");
                e.Property(e => e.Subject).HasColumnType("NVARCHAR(20)").HasColumnName("subject");
                e.Property(e => e.Salary).HasColumnType("int").HasColumnName("salary");
            });

            modelBuilder.Entity<User>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();
                e.Property(e => e.Username).HasColumnName("username").HasColumnType("NVARCHAR(20)");
                e.Property(e => e.Password).HasColumnName("password").HasColumnType("NVARCHAR(20)");
            });
        }
    }
}
