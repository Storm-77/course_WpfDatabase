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
            if (e.PropertyName == nameof(TableCreationViewModel.SelectedIndex) || e.PropertyName == nameof(TableCreationViewModel.SelectedItem))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            if (m_tableCreationViewModel.SelectedIndex == -1 || m_columns.Count <= 1)
                return false;

            int index = m_tableCreationViewModel.SelectedIndex;
            if (m_offset != 0)
            {
                return index != -1 && index + m_offset >= 0 && index + m_offset < m_columns.Count;
            }
            else
            {
                //logic for target index
                int i = m_targetIndex;
                if (m_targetIndex == -1)
                    i = m_columns.Count - 1;

                return index != -1 && i != index;
            }

        }

        public override void Execute(object parameter)
        {
            int index = m_tableCreationViewModel.SelectedIndex;
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

            OnCanExecuteChanged();
        }
    }
}
