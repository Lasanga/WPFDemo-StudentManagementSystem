using SMS.Service.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.DatabaseContext
{
    public interface IStudentContext
    {
        DbSet<Student> Students { get; set; }
    }
}
