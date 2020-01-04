using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Frontend.ViewModels
{
    public class IndexViewModel : Conductor<object>
    {
        public IndexViewModel()
        {
            ActivateItem(new StudentsViewModel());
        }

        public void LoadPageStudents()
        {
            ActivateItem(new StudentsViewModel());
        }

        public void LoadPageReports()
        {
            ActivateItem(new StudentsViewModel());
        }

        public void LoadPageExams()
        {
            ActivateItem(new StudentsViewModel());
        }
    }
}
