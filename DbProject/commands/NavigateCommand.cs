using DbProject.viewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.commands
{
    class NavigateCommand : CommandBase
    {
        private readonly viewModels.ViewModelBase m_target;

        public NavigateCommand(ViewModelBase target)
        {
            m_target = target;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            viewModels.MainViewModel.SetViewModel(m_target);
        }
    }
}
