using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DbProject.viewModels
{
    class MenuViewModel : ViewModelBase
    {

        public MenuViewModel()
        {
            SomeCommand = new commands.MessageCommand("that is my message to you");
        }

        private ICommand m_someCommand;
        public ICommand SomeCommand
        {
            get
            {
                return m_someCommand;
            }
            set
            {
                m_someCommand = value;
                this.OnPropertyChanged(nameof(SomeCommand));
            }
        }
    }
}
