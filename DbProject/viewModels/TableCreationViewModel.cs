using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace DbProject.viewModels
{
    class TableCreationViewModel : ViewModelBase
    {
        private ObservableCollection<TableColumnViewModel> m_columns;

        public IEnumerable<TableColumnViewModel> Columns => m_columns;


        public TableCreationViewModel()
        {
            m_columns = new();
            AddColumnCommand = new commands.AddColumnCommand(m_columns);
            RemoveColumnCommand = new commands.RemoveColumnCommand(this, m_columns);

            MoveColumnUpCommand = new commands.ReorderColumnCommand(this, true);
            MoveColumnDownCommand = new commands.ReorderColumnCommand(this, false);
            MoveColumnTopCommand = new commands.ReorderColumnCommand(this, 0);
            MoveColumnBottomCommand = new commands.ReorderColumnCommand(this, -1);
        }

        private TableColumnViewModel m_selectedItem;
        public TableColumnViewModel SelectedItem
        {
            get
            {
                return m_selectedItem;
            }
            set
            {
                m_selectedItem = value;
                this.OnPropertyChanged(nameof(SelectedItem));
            }
        } 
        
        private int m_selectedIndex;
        public int SelectedIndex
        {
            get
            {
                return m_selectedIndex;
            }
            set
            {
                m_selectedIndex = value;
                this.OnPropertyChanged(nameof(SelectedIndex));
            }
        }

        private string m_name;
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
                this.OnPropertyChanged(nameof(Name));
            }
        }

        private ICommand m_addColumnCommand;
        public ICommand AddColumnCommand
        {
            get
            {
                return m_addColumnCommand;
            }
            set
            {
                m_addColumnCommand = value;
                this.OnPropertyChanged(nameof(AddColumnCommand));
            }
        }
        
        private ICommand m_removeColumnCommand;
        public ICommand RemoveColumnCommand
        {
            get
            {
                return m_removeColumnCommand;
            }
            set
            {
                m_removeColumnCommand = value;
                this.OnPropertyChanged(nameof(RemoveColumnCommand));
            }
        } 
        

        private ICommand m_moveColumnUpCommand;
        public ICommand MoveColumnUpCommand
        {
            get
            {
                return m_moveColumnUpCommand;
            }
            set
            {
                m_moveColumnUpCommand = value;
                this.OnPropertyChanged(nameof(MoveColumnUpCommand));
            }
        }
        
        private ICommand m_moveColumnDownCommand;
        public ICommand MoveColumnDownCommand
        {
            get
            {
                return m_moveColumnDownCommand;
            }
            set
            {
                m_moveColumnDownCommand = value;
                this.OnPropertyChanged(nameof(MoveColumnDownCommand));
            }
        }
        
        private ICommand m_moveColumnBottomCommand;
        public ICommand MoveColumnBottomCommand
        {
            get
            {
                return m_moveColumnBottomCommand;
            }
            set
            {
                m_moveColumnBottomCommand = value;
                this.OnPropertyChanged(nameof(MoveColumnBottomCommand));
            }
        } 
        
        private ICommand m_moveColumnTopCommand;
        public ICommand MoveColumnTopCommand
        {
            get
            {
                return m_moveColumnTopCommand;
            }
            set
            {
                m_moveColumnTopCommand = value;
                this.OnPropertyChanged(nameof(MoveColumnTopCommand));
            }
        }

    }
}
