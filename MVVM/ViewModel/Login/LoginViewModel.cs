using MVVM.ViewModel.Common;
using System;
using System.Windows;
using static MVVM.Model.Login.LogninModel;

namespace MVVM.ViewModel.Login
{
    public class LoginViewModel: NotificationObject
    {
        /// <summary>
        /// Model对象
        /// </summary>
        private LoginModel obj = new LoginModel();

        private BaseCommand clickLoginCommand;

        private BaseCommand loginClick;

        private bool toClose = false;

        public LoginViewModel()
        {
            obj.UserName = "test";
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get
            {
                return obj.UserName;
            }
            set
            {
                obj.UserName = value;
                this.RaisePropertyChanged("UserName");
            }
        }


        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get
            {
                return obj.Password;
            }
            set
            {
                obj.Password = value;
                this.RaisePropertyChanged("Password");
            }
        }


        /// <summary>
        /// 性别
        /// </summary>
        public int Gender
        {
            get
            {
                return obj.Gender;
            }
            set
            {
                obj.Gender = value;
                this.RaisePropertyChanged("Gender");
            }
        }

        //public BaseCommand ClickLoginCommand
        //{
        //    get
        //    {
        //        if (clickLoginCommand == null)
        //        {
        //            clickLoginCommand = new BaseCommand(new Action<object>(o =>
        //            {
        //                MessageBox.Show("事件2触发");
        //                //执行登录逻辑
        //            }));
        //        }
        //        return clickLoginCommand;
        //    }
        //}


        /// <summary>
        /// 登录事件
        /// </summary>
        public BaseCommand LoginClick
        {
            get
            {
                if (loginClick == null)
                {
                    loginClick = new BaseCommand(new Action<object>(o =>
                    {
                        var a = obj;
                        MessageBox.Show("登录事件触发");
                        WindowManager.Show("MainWindow", null);
                        ToClose = true;
                        //执行登录逻辑
                    }));
                }
                return loginClick;
            }
        }

        /// <summary>
        /// 是否要关闭窗口
        /// </summary>
        public bool ToClose
        {
            get
            {
                return toClose;
            }
            set
            {
                toClose = value;
                if (toClose)
                {
                    this.RaisePropertyChanged("ToClose");
                }
            }
        }
    }
}
