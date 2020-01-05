using Caliburn.Micro;
using SMS.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Frontend.ViewModels
{
    public class IndexViewModel : Conductor<object>
    {
        private readonly IStudentService _studentService;
        private StudentsViewModel _studentsViewModel;

        public IndexViewModel(IStudentService studentService, StudentsViewModel studentsViewModel)
        {
            _studentService = studentService;
            _studentsViewModel = studentsViewModel;
            ActivateItem(_studentsViewModel);
        }

        public void LoadPageStudents()
        {
            //ActivateItem(new StudentsViewModel());
        }

        public void LoadPageReports()
        {
           // ActivateItem(new StudentsViewModel());
        }

        public void LoadPageExams()
        {
            //ActivateItem(new StudentsViewModel());
        }
    }
}
