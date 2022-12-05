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
    public class LecturerService : ILecturerService
    {
        private readonly ILecturerRepository _lecturerRepository;
        private readonly IUserRepository _userRepository;

        public LecturerService(ILecturerRepository lecturerRepository, IUserRepository userRepository)
        {
            _lecturerRepository = lecturerRepository;
            _userRepository = userRepository;
        }

        public LecturerDto Create(CreateLecturerRequestModel model)
        {
            var user = new User
            {
                Email = model.Email,
                PassWord = model.PassWord
            };
            _userRepository.Add(user);
            var lecturer = new Lecturer{
                FirstName=model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                DepartmentId = model.DepartmentId,
                UserId = user.Id
            };
            var lecturerInfo = _lecturerRepository.Add(lecturer);
            foreach(var item in model.CourseIds)
            {
                var lecturerCourse = new CourseLecturer
                {
                    CourseId = item,
                    LecturerId = lecturer.Id
                };
                lecturer.CourseLecturers.Add(lecturerCourse);
            }
            return new LecturerDto
            {
                FirstName = lecturerInfo.FirstName,
                LastName = lecturerInfo.LastName,
                PhoneNumber = lecturerInfo.PhoneNumber
            };
        }

        public void Delete(int id)
        {
            var lecturer = _lecturerRepository.Get(id);
            _lecturerRepository.Delete(lecturer);
        }

        public LecturerDto Get(int id)
        {
            var lecturer = _lecturerRepository.Get(id);
            return new LecturerDto
            {
                FirstName= lecturer.FirstName,
                LastName =lecturer.LastName,
                PhoneNumber = lecturer.PhoneNumber
            };
        }

        public IList<LecturerDto> GetAll()
        {
            return _lecturerRepository.GetAll().Select( a=> new LecturerDto{
                FirstName= a.FirstName,
                LastName =a.LastName,
                PhoneNumber = a.PhoneNumber
            }).ToList();
        }

        public LecturerDto Update(int id, UpdateLecturerRequestModel model)
        {
            var lecturer = _lecturerRepository.Get(id);
            var user = _userRepository.Get(lecturer.UserId);
            user.PassWord =model.PassWord;
            lecturer.FirstName = model.FirstName;
            lecturer.LastName = model.LastName;
            lecturer.PhoneNumber = model.PhoneNumber;
            var lecturerInfo = _lecturerRepository.Update(lecturer);
            _userRepository.Update(user);
            return new LecturerDto
            {
                FirstName= lecturerInfo.FirstName,
                LastName =lecturerInfo.LastName,
                PhoneNumber = lecturerInfo.PhoneNumber
            };
        }
    }
}