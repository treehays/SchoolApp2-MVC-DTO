using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp2.Dto;
using SchoolApp2.Interface.Repository;
using SchoolApp2.Interface.Service;
using SchoolApp2.Models;

namespace SchoolApp2.Implementation.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseDto Create(CreateCourseRequestModel model)
        {
            
           var course = new Course
           {
                CourseName = model.CourseName,
                DepartmentId = model.DepartmentId,
                CourseCode = model.CourseCode,
                
           };
           var courseInfo = _courseRepository.Add(course);
            return  new CourseDto{
           
                CourseCode = courseInfo.CourseCode,
                CourseName = courseInfo.CourseName,
                Id = courseInfo.Id
            };
          

        }

        public void Delete(int id)
        {
            var course = _courseRepository.Get(id);
            _courseRepository.Delete(course);
        }

        public CourseDto Get(int id)
        {
            var course = _courseRepository.Get(id);
            return new CourseDto
            {
               CourseCode = course.CourseCode,
                CourseName = course.CourseName 
            };
        }

        public IList<CourseDto> GetAll()
        {
            return _courseRepository.GetAll().Select( a => new CourseDto
            {
                CourseCode = a.CourseCode,
                CourseName = a.CourseName
            }).ToList();
        }

        public CourseDto Update(int id, UpdateCourseRequestModel model)
        {
            var course =_courseRepository.Get(id);
            course.CourseCode = model.CourseCode;
            course.CourseCode =model.CourseCode;
           var courseInfo =  _courseRepository.Update(course);
           return new CourseDto
           {
                CourseCode = courseInfo.CourseCode,
                CourseName = courseInfo.CourseName
           };

        }
    }
}