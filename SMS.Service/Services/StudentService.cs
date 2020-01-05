using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Service.DatabaseContext;
using SMS.Service.Models;

namespace SMS.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentContext _dbContext;

        public StudentService(IStudentContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Student> GetAllStudents()
        {
            return _dbContext.Students.ToList();
        }
    }
}
