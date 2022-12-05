using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp2.Models
{

    public class Course
    {
        
        public int Id {get;set;}
        public int DepartmentId {get;set;}
        public Department Department {get;set;}
        public string CourseName {get;set;}
        public string CourseCode{get;set;}
        public IList<CourseLecturer> CourseLecturers {get;set;} = new List<CourseLecturer>();
        public IList<CourseStudent> CourseStudents {get;set;} = new List<CourseStudent>();
    }
}