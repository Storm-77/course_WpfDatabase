using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DbProject.commands
{
    class LoginCommand : CommandBase
    {
        private readonly viewModels.LoginViewModel m_loginData;
        public LoginCommand(viewModels.LoginViewModel loginData)
        {
            m_loginData = loginData;
            m_loginData.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object parameter) 
        {
            return ! (string.IsNullOrEmpty(m_loginData.Login) || string.IsNullOrEmpty(m_loginData.Password));
        }

        public override void Execute(object parameter)
        {

            if (m_loginData.Login == "admin" && m_loginData.Password == "password")
            {
                //MessageBox.Show("Login successfull!", "Good", MessageBoxButton.OK, MessageBoxImage.Information);
                viewModels.MainViewModel.SetViewModel(new viewModels.MenuViewModel());
            }
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(viewModels.LoginViewModel.Login) ||
                e.PropertyName == nameof(viewModels.LoginViewModel.Password))
            {
                OnCanExecuteChanged();
            }
            
        }
       
    }
}
