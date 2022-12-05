using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp2.Dto
{
    public class CourseDto
    {
        public int Id {get;set;}
        public string DepartmentName {get;set;}
        public string CourseName {get;set;}
        public string CourseCode{get;set;}
        public IList<LecturerDto> Lecturers {get;set;} = new List<LecturerDto>();
       
    }
    public class CreateCourseRequestModel
    {
        public int DepartmentId {get;set;}
        public string CourseName {get;set;}
        public string CourseCode{get;set;}   
    }
        public class UpdateCourseRequestModel
    {
      
        public string CourseName {get;set;}
        public string CourseCode{get;set;}   
    }
}