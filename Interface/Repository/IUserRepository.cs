using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp2.Models;

namespace SchoolApp2.Interface.Repository
{
    public interface IUserRepository
    {
        User Add(User User);
        User Update(User User);
        User Get(int id);
        void Delete(User user);
        IList<User> GetAll();
        IList<Department> DeptList ();
    }
}