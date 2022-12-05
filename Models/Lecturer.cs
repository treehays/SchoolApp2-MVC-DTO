using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp2.Models
{
    public class Lecturer
    {
        public int Id {get;set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int DepartmentId {get;set;}
        public Department Department {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string PhoneNumber {get;set;}
        public IList<CourseLecturer> CourseLecturers {get;set;} = new List<CourseLecturer>();
        public IList<LecturerStudent> LecturerStudents {get;set;} = new List<LecturerStudent>();


    }
}