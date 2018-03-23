using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVMCustomPresentation.Commands;
using MVVMCustomPresentation.Models;

namespace MVVMCustomPresentation.ViewModels
{
    internal class CustomerViewModel
    {

        private Customer customer;

        public CustomerViewModel()
        {
            customer = new Customer("Thomas");
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        

        public Customer Customer
        {
            get { return customer; }
        }

        public ICommand UpdateCommand { get; private set; }

        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} As updated", Customer.Name));
        }
    }
}
