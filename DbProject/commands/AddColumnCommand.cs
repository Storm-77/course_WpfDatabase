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

        public AddColumnCommand(ObservableCollection<TableColumnViewModel> columns)
        {
            m_columns = columns;
        }

        public override void Execute(object parameter)
        {
            var column = new viewModels.TableColumnViewModel();
            column.Name = $"column-{m_columns.Count}";
            m_columns.Add(column);
        }
    }
}
