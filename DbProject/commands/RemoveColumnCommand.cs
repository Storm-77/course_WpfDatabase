using DbProject.viewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.commands
{
    class RemoveColumnCommand : CommandBase
    {
        private readonly TableCreationViewModel m_tableCreationViewModel;
        private readonly ObservableCollection<TableColumnViewModel> m_collection;

        public RemoveColumnCommand(TableCreationViewModel tableCreationViewModel, ObservableCollection<TableColumnViewModel> collection)
        {
            m_tableCreationViewModel = tableCreationViewModel;
            m_collection = collection;
            m_tableCreationViewModel.PropertyChanged += TableCreationViewModelPropertyChanged;
        }

        private void TableCreationViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(TableCreationViewModel.SelectedItem))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return m_collection.Count > 0 && m_tableCreationViewModel.SelectedItem != null;
        }

        public override void Execute(object parameter)
        {
            m_collection.Remove(m_tableCreationViewModel.SelectedItem);
        }
    }
}
