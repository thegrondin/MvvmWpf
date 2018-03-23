using System;
using System.ComponentModel;

namespace MVVMCustomPresentation.Models
{
    public class Customer :INotifyPropertyChanged, IDataErrorInfo
    {
        private string name;
        public Customer(String customerName)
        {
            Name = customerName;
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyChanged)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyChanged));
            }
        }

        public string Error { get; private set; }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Name")
                {
                    if (String.IsNullOrWhiteSpace(Name))
                    {
                        Error = "Name cannot be null or empty";
                    }
                    else
                    {
                        Error = null;
                    }
                }

                return Error;
            }
        }
    }
}
