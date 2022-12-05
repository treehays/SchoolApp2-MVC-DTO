using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp2.AppContext;
using SchoolApp2.Interface.Repository;
using SchoolApp2.Models;

namespace SchoolApp2.Implementation.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly Context _context;

        public CourseRepository()
        {
            _context = new Context();
        }

        public Course Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
        }

        public void Delete(Course course)
        {
            _context.Courses.Remove(course);
            _context.SaveChanges();
        }

        public Course Get(int id)
        {
            return _context.Courses.SingleOrDefault(a => a.Id == id);
        }

        public IList<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public Course Update(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
            return course;
        }
    }
}