using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp2.Models;

namespace SchoolApp2.Interface.Repository
{
    public interface ICourseRepository
    {
        Course Add(Course course);
        Course Update(Course course);
        Course Get(int id);
        void Delete(Course course);
        IList<Course> GetAll();
    }
}