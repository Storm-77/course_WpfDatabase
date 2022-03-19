using DbProject.viewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.commands
{
    class AddColumnCommand : CommandBase
    {
        private readonly ObservableCollection<viewModels.TableColumnViewModel> m_columns;
        private readonly TableCreationViewModel m_tableCreationViewModel;

        public AddColumnCommand(TableCreationViewModel tableCreationViewModel,ObservableCollection<TableColumnViewModel> columns)
        {
            m_columns = columns;
            m_tableCreationViewModel = tableCreationViewModel;
        }

        public override void Execute(object parameter)
        {
            var column = new viewModels.TableColumnViewModel();
            column.Name = $"column-{m_columns.Count}";
            column.PropertyChanged += Column_PropertyChanged;
            m_columns.Add(column);
        }

        private void Column_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
           m_tableCreationViewModel.GenSql();
        }
    }
}
