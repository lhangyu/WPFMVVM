using MVVM.Model.Student;
using MVVM.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel.Student
{
    public class StudentViewModel: NotificationObject
    {
        private StudentModel obj = new StudentModel();

        private BaseCommand showStudentData;

        public StudentViewModel()
        {

        }

        /// <summary>
        /// 学号
        /// </summary>
        public int StudentId
        {
            get
            {
                return obj.StudentId;
            }
            set
            {
                obj.StudentId = value;
                this.RaisePropertyChanged("StudentId");
            }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string StudentName
        {
            get
            {
                return obj.StudentName;
            }
            set
            {
                obj.StudentName = value;
                this.RaisePropertyChanged("StudentName");
            }
        }

        /// <summary>
        /// 年龄
        /// </summary>
        public int StudentAge
        {
            get
            {
                return obj.StudentAge;
            }
            set
            {
                obj.StudentAge = value;
                this.RaisePropertyChanged("StudentAge");
            }
        }

        /// <summary>
        /// email
        /// </summary>
        public string StudentEmail
        {
            get
            {
                return obj.StudentEmail;
            }
            set
            {
                obj.StudentEmail = value;
                this.RaisePropertyChanged("StudentEmail");
            }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string StudentSex
        {
            get
            {
                return obj.StudentSex;
            }
            set
            {
                obj.StudentSex = value;
                this.RaisePropertyChanged("StudentSex");
            }
        }

        public BaseCommand ShowStudentData
        {
             get
            {
                if (showStudentData == null)
                {
                    showStudentData = new BaseCommand(new Action<object>(o =>
                    {
                        obj.StudentId = 1;
                        obj.StudentName = "tiana";
                        obj.StudentAge = 20;
                        obj.StudentEmail = "8644003248@qq.com";
                        obj.StudentSex = "大帅哥";
                    }));
                }
                return showStudentData;
            }
        }

        
    }
}
