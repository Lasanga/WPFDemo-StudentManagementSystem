using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Frontend.Model
{
    public class StudentDto
    {
        public int Id { get; set; }
        public bool IsSelectedForDelete { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }
}
