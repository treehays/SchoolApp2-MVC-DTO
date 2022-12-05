using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp2.AppContext;
using SchoolApp2.Interface.Repository;
using SchoolApp2.Models;

namespace SchoolApp2.Implementation.Repository
{
    public class LecturerRepository : ILecturerRepository
    {
        
        private readonly Context _context;

        public LecturerRepository()
        {
            _context = new Context();
        }

        public Lecturer Add(Lecturer lecturer)
        {
            _context.Lecturers.Add(lecturer);
            _context.SaveChanges();
            return lecturer;
        }

        public void Delete(Lecturer lecturer)
        {
            _context.Lecturers.Remove(lecturer);
            _context.SaveChanges();
        }

       

        public Lecturer Get(int id)
        {
            return _context.Lecturers.SingleOrDefault(a => a.Id == id);
        }

        public IList<Lecturer> GetAll()
        {
            return _context.Lecturers.ToList();
        }

        public Lecturer Update(Lecturer lecturer)
        {
            _context.Lecturers.Update(lecturer);
            _context.SaveChanges();
            return lecturer;
        }
        
    }
}