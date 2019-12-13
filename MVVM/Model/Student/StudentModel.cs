using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model.Student
{
    public class StudentModel
    {
        /// <summary>
        /// 学号
        /// </summary>
        public int StudentId{get;set;}

        /// <summary>
        /// 姓名
        /// </summary>
        public string StudentName { get; set; }
       
        /// <summary>
        /// 年龄
        /// </summary>
        public int StudentAge { get; set; }
        
        /// <summary>
        /// Email
        /// </summary>
        public string StudentEmail { get; set; }
       
        /// <summary>
        /// 性别
        /// </summary>
        public string StudentSex { get; set; }
    }
}
