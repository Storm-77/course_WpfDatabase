using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DbProject.viewModels
{
    class LoginViewModel : ViewModelBase
    {
        private ICommand _loginCommand;
        private string m_login;
        private string m_password;

        public string Login
        {
            get
            {
                return m_login;
            }
            set
            {
                m_login = value;
            }
        }

        public LoginViewModel()
        {
            _loginCommand = new commands.LoginCommand();
        }

    }
}
