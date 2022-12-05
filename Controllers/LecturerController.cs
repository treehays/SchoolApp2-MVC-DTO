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
    public class LecturerController : Controller
    {
        private readonly ILecturerService _lecturerService;
        private readonly ICourseService _courseService;
        private readonly IUserRepository _userRepository;

        public LecturerController(ILecturerService lecturerService, ICourseService courseService, IUserRepository userRepository)
        {
            _lecturerService = lecturerService;
            _courseService = courseService;
            _userRepository = userRepository;
        }

        public IActionResult Lecturers()
        {
            var lecturers = _lecturerService.GetAll();
            return View(lecturers);
        }


        [HttpGet("{id}")]
         public IActionResult Details(int id)
        {
            var student = _lecturerService.Get(id);
            return View(student);
        }

        public IActionResult AddLecturer()
        {
            var dept = _userRepository.DeptList();
            ViewData["dept"] = new SelectList(dept,"Id","DepartmentName");
            var courses = _courseService.GetAll();
            ViewData["Courses"] = new SelectList(courses, "Id" , "CourseName");
            return View();
        }

        [HttpPost]
         public IActionResult AddLecturer(CreateLecturerRequestModel request)
        {
           var lecturer = _lecturerService.Create(request);
            return RedirectToAction(nameof(Lecturers));
        }

  
    }
}