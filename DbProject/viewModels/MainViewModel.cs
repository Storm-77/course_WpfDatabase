using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.viewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentViewModel;
        public MainViewModel(ViewModelBase initial)
        {
            CurrentViewModel = initial;

        }

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public static void SetViewModel(viewModels.ViewModelBase nextViewModel)
        {
            var vm = App.Current.MainWindow.DataContext as MainViewModel;
            vm.CurrentViewModel = nextViewModel;
        }
    }
}
