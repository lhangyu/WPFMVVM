using MVVM.Model.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModel.Student
{
    public class Student1ViewModel
    {
            public DelegateCommand ShowCommand { get; set; }
            public Student1Model Student { get; set; }
            public Student1ViewModel()
            {
                Student = new Student1Model();
                ShowCommand = new DelegateCommand();
                ShowCommand.ExecuteCommand = new Action<object>(ShowStudentData);
            }
            private void ShowStudentData(object obj)
            {
                Student.StudentId = 1;
                Student.StudentName = "tiana";
                Student.StudentAge = 20;
                Student.StudentEmail = "8644003248@qq.com";
                Student.StudentSex = "大帅哥";
            }

        }

        public class DelegateCommand : ICommand
        {
            public Action<object> ExecuteCommand = null;
            public Func<object, bool> CanExecuteCommand = null;
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                if (CanExecuteCommand != null)
                {
                    return this.CanExecuteCommand(parameter);
                }
                else
                {
                    return true;
                }
            }

            public void Execute(object parameter)
            {
                if (this.ExecuteCommand != null)
                {
                    this.ExecuteCommand(parameter);
                }
            }

            public void RaiseCanExecuteChanged()
            {
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(this, EventArgs.Empty);
                }
            }
        }
    
}
