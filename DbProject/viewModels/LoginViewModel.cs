using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DbProject.viewModels
{
    class LoginViewModel : ViewModelBase
    {

        private string m_login;
        public string Login
        {
            get
            {
                return m_login;
            }
            set
            {
                m_login = value;
                this.OnPropertyChanged(nameof(Login));
            }
        }

        private string m_password;
        public string Password
        {
            get
            {
                return m_password;
            }
            set
            {
                m_password = value;
                this.OnPropertyChanged(nameof(Password));
            }
        }

        private ICommand m_loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                return m_loginCommand;
            }
            set
            {
                m_loginCommand = value;
                this.OnPropertyChanged(nameof(LoginCommand));
            }
        }

        public LoginViewModel()
        {
            LoginCommand = new commands.LoginCommand(this);
        }

    }
}
