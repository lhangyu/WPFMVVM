using MVVM.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MVVM.ViewModel.LogninModel;

namespace MVVM.ViewModel.Login
{
    public class LoginViewModel: NotificationObject
    {
        /// <summary>
        /// Model对象
        /// </summary>
        private LoginModel obj = new LoginModel();

        private BaseCommand clickLoginCommand;

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


        public BaseCommand ClickLoginCommand
        {
            get
            {
                if (clickLoginCommand == null)
                {
                    clickLoginCommand = new BaseCommand(new Action<object>(o =>
                    {
                        //执行登录逻辑
                    }));
                }
                return clickLoginCommand;
            }
        }
    }
}
