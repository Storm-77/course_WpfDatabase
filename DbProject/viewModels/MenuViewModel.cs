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
            CreateTableBtn = new commands.NavigateCommand(new viewModels.TableCreationViewModel());
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
        
        private ICommand m_createTable;
        public ICommand CreateTableBtn
        {
            get
            {
                return m_createTable;
            }
            set
            {
                m_createTable= value;
                this.OnPropertyChanged(nameof(CreateTableBtn));
            }
        }
    }
}
