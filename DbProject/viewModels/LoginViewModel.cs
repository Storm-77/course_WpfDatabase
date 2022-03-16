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
        private ICommand m_loginCommand;    
        private string m_login;
        private string m_password;
        public LoginViewModel()
        {
            m_loginCommand = new commands.LoginCommand();
        }

    }
}
