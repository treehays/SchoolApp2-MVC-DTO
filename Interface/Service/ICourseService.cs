using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp2.Dto;

namespace SchoolApp2.Interface.Service
{
    public interface ICourseService
    {
        CourseDto Create(CreateCourseRequestModel model);
        CourseDto Update(int id, UpdateCourseRequestModel model);
        CourseDto Get(int id);
        IList<CourseDto> GetAll();
        void Delete(int id);
    }
}