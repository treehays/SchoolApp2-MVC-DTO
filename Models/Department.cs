using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp2.Models
{
    public class Department
    {
         public int Id {get;set;}
        public string DepartmentName {get;set;}
        public IList<Course> Courses {get;set;} = new List<Course>();
        public IList<Student> Students {get;set;} = new List<Student>();
        public IList<Lecturer> Lecturers {get;set;} = new List<Lecturer>();
        
    }
}