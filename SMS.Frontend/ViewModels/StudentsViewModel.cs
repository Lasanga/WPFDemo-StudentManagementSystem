using Caliburn.Micro;
using SMS.Frontend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Frontend.ViewModels
{
    public class StudentsViewModel : Screen
    {
        public StudentsViewModel()
        {
            Students.Add(new StudentDto { Id = 1, Age = 20, FirstName = "Lasanga", SecondName = " Guruge", FullName = "Lasanga Guruge", Grade = 10 });
            Students.Add(new StudentDto { Id = 2, Age = 21, FirstName = "Ravindu", SecondName = " Guruge", FullName = "Ravindu Guruge", Grade = 11 });
            Students.Add(new StudentDto { Id = 3, Age = 30, FirstName = "Loku", SecondName = " Bro", FullName = "Loku Bro", Grade = 15 });
            Students.Add(new StudentDto { Id = 4, Age = 15, FirstName = "Saminda", SecondName = " Wije", FullName = "Saminda Wije", Grade = 10 });
            Students.Add(new StudentDto { Id = 5, Age = 11, FirstName = "Tweet", SecondName = " Insta", FullName = "Tweet Insa", Grade = 13 });
        }

        private BindableCollection<StudentDto> _students = new BindableCollection<StudentDto>();

        public BindableCollection<StudentDto> Students
        {
            get { return _students; }
            set{_students = value; }
        }

        private StudentDto _student;

        public StudentDto SelectedStudent
        {
            get { return _student; }
            set { 
                _student = value;
                NotifyOfPropertyChange(() => CanDeleteStudent);
            }
        }


        public bool CanDeleteStudent => Students.Any(x => x.IsSelectedForDelete);

        public void DeleteStudent()
        {

        }
    }
}
