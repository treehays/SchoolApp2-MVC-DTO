using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp2.Dto;

namespace SchoolApp2.Interface.Service
{
    public interface ILecturerService
    {
        LecturerDto Create(CreateLecturerRequestModel model);
        LecturerDto Update(int id, UpdateLecturerRequestModel model);
        LecturerDto Get(int id);
        IList<LecturerDto> GetAll();
        void Delete(int id);
    }
}