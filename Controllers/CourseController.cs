using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolApp2.Dto;
using SchoolApp2.Interface.Repository;
using SchoolApp2.Interface.Service;

namespace SchoolApp2.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IUserRepository _userRepository;

        public CourseController(ICourseService courseService, IUserRepository userRepository)
        {
            _courseService = courseService;
            _userRepository = userRepository;
        }

        public IActionResult Courses()
        {
            var courses = _courseService.GetAll();
            return View(courses);
        }


        [HttpGet("{id}")]
         public IActionResult Details(int id)
        {
            var course = _courseService.Get(id);
            return View(course);
        }

        public IActionResult AddCourse()
        {
            var dept = _userRepository.DeptList();
            ViewData["dept"] = new SelectList(dept,"Id","DepartmentName");
            
            return View();
        }

        [HttpPost]
         public IActionResult AddCourse(CreateCourseRequestModel request)
        {
           var course = _courseService.Create(request);
            return RedirectToAction(nameof(Courses));
        }

       
    }
}