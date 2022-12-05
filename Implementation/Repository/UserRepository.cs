using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp2.AppContext;
using SchoolApp2.Interface.Repository;
using SchoolApp2.Models;

namespace SchoolApp2.Implementation.Repository
{
    public class UserRepository : IUserRepository
    {
         private readonly Context _context;

        public UserRepository()
        {
            _context = new Context();
        }

        public User Add(User user)
        {
            AddDept();
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public void AddDept ()
        {
            var dept = new Department{DepartmentName = "Sociology" };
            _context.Departments.Add(dept);
          
        }
          public IList<Department> DeptList ()
        {
           return _context.Departments.ToList();
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

       

        public User Get(int id)
        {
            return _context.Users.SingleOrDefault(a => a.Id == id);
        }

        public IList<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}