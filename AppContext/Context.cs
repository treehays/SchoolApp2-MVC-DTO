using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApp2.Models;

namespace SchoolApp2.AppContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;port=3306;Database=SchoolApp2;Uid=root;Pwd=1234",new MySqlServerVersion(new Version("8.0.29")));

        }
        public DbSet<Student> Students{get; set;}
        public DbSet<Lecturer> Lecturers{get; set;}
        public DbSet<Department> Departments{get; set;}
        public DbSet<Course> Courses{get; set;}
        public DbSet<User> Users{get; set;}
        public DbSet<LecturerStudent> LecturerStudents{get; set;}
        public DbSet<CourseStudent> CourseStudents{get; set;}
        public DbSet<CourseLecturer> CourseLecturers{get; set;}
    }
}