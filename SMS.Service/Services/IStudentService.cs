using SMS.Service.Models;
using System.Collections.Generic;

namespace SMS.Service.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
    }
}