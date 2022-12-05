using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp2.Models
{
    public class User
    {
        public int Id {get;set;}
        public Lecturer Lecturer {get;set;}
        public Student Student {get;set;}
        public string Email {get;set;}
        public string PassWord {get;set;}
    }
}