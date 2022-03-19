using DbProject.viewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.commands
{

    class ReorderColumnCommand : CommandBase
    {
        private readonly TableCreationViewModel m_tableCreationViewModel;
        private readonly ObservableCollection<TableColumnViewModel> m_columns;
        private readonly int m_offset;
        private readonly int m_targetIndex;

        public ReorderColumnCommand(TableCreationViewModel model, int target)
        {
            m_tableCreationViewModel = model;
            m_offset = 0;
            m_targetIndex = target;
            m_columns = m_tableCreationViewModel.Columns as ObservableCollection<TableColumnViewModel>;

            m_tableCreationViewModel.PropertyChanged += TableCreationViewModel_PropertyChanged;
        }

        public ReorderColumnCommand(TableCreationViewModel model, bool up)
        {
            m_tableCreationViewModel = model;
            m_offset = up ? -1 : 1;
            m_columns = m_tableCreationViewModel.Columns as ObservableCollection<TableColumnViewModel>;

            m_tableCreationViewModel.PropertyChanged += TableCreationViewModel_PropertyChanged;
        }

        private void TableCreationViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(TableCreationViewModel.SelectedItem))
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            if (m_tableCreationViewModel.SelectedItem == null || m_columns.Count <= 1)
                return false;

            int index = m_columns.IndexOf(m_tableCreationViewModel.SelectedItem);
            if (m_offset != 0)
            {

                bool chk = index + m_offset >= 0;
                bool chk1 = index + m_offset < m_columns.Count;

                return index != -1 && chk && chk1;
            }
            else
            {
                return true;
            }

        }

        public override void Execute(object parameter)
        {
            int index = m_columns.IndexOf(m_tableCreationViewModel.SelectedItem);
            if (m_offset != 0)
            {
                m_columns.Move(index, index + m_offset);
                return;
            }
            if (m_targetIndex == -1)
            {
                m_columns.Move(index, m_columns.Count - 1);
                return;
            }

            m_columns.Move(index, m_targetIndex);
        }
    }
}
