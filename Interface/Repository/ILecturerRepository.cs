using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp2.Models;

namespace SchoolApp2.Interface.Repository
{
    public interface ILecturerRepository
    {
        Lecturer Add(Lecturer Lecturer);
        Lecturer Update(Lecturer Lecturer);
        Lecturer Get(int id);
        void Delete(Lecturer Lecturer);
        IList<Lecturer> GetAll();
    }
}