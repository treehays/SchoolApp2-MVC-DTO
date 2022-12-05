using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp2.Models
{
    public class LecturerStudent
    {
        public int Id {get;set;}
        public int LecturerId {get;set;}
         public Lecturer Lecturer {get;set;}
        public int StudentId {get;set;}
         public Student Student {get;set;}
    }
}