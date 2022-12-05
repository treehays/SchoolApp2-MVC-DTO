using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp2.Dto
{
    public class LecturerDto
    {
        public int Id {get;set;}
        public string Email {get;set;}
        public string DepartmentName {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string PhoneNumber {get;set;}
        public IList<CourseDto> CourseLecturers {get;set;} = new List<CourseDto>();

    }
    public class CreateLecturerRequestModel
    {
        public int DepartmentId {get;set;}
        public IList<int> CourseIds{get;set;}= new List<int>();
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string PhoneNumber {get;set;}
        public string Email {get;set;}
        public string PassWord {get;set;}
    }
     public class UpdateLecturerRequestModel
    {
        
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string PhoneNumber {get;set;}
        public string PassWord {get;set;}
    }
}