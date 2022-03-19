using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace DbProject.viewModels
{
    partial class TableCreationViewModel : ViewModelBase
    {
        private ObservableCollection<TableColumnViewModel> m_columns;

        public IEnumerable<TableColumnViewModel> Columns => m_columns;

        public TableCreationViewModel()
        {
            m_columns = new();
            AddColumnCommand = new commands.AddColumnCommand(this,m_columns);
            RemoveColumnCommand = new commands.RemoveColumnCommand(this, m_columns);

            MoveColumnUpCommand = new commands.ReorderColumnCommand(this, true);
            MoveColumnDownCommand = new commands.ReorderColumnCommand(this, false);
            MoveColumnTopCommand = new commands.ReorderColumnCommand(this, 0);
            MoveColumnBottomCommand = new commands.ReorderColumnCommand(this, -1);
            m_columns.CollectionChanged += CollectionChanged;
            PropertyChanged += NamePropertyChanged;
        }

        private void NamePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Name))
                GenSql();
        }

        private void CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            GenSql();
        }

        public void GenSql()
        {
            string sql =
            $"CREATE TABLE {Name} (\n";

            foreach(var col in m_columns)
            {
                sql += '\t';
                sql += col.ToSql();
                if(col != m_columns.Last())
                {
                    sql += ',';
                    sql += '\n';
                }
            }

            sql += $"\n);";

            SqlStatement = sql;
        }

    }
}
