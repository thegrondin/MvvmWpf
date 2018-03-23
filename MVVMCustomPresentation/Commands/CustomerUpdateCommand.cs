using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVMCustomPresentation.ViewModels;

namespace MVVMCustomPresentation.Commands
{
    class CustomerUpdateCommand : ICommand
    {
        public CustomerUpdateCommand(CustomerViewModel viewModel)
        {
            _ViewModel = viewModel;
        }

        private CustomerViewModel _ViewModel;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return String.IsNullOrWhiteSpace(_ViewModel.Customer.Error);
        }

        public void Execute(object parameter)
        {
            _ViewModel.SaveChanges();
        }
    }
}
