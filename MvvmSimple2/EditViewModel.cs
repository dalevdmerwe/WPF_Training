using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MvvmSimple2
{
    public class EditViewModel : INotifyPropertyChanged
    {
        private string displayMessage;
        private ObservableCollection<string> itemsCollection;
        private EditModel _editModel;
        private ICommand addCommand;
        

        public EditViewModel()
        {
            _editModel = new EditModel(); // important – must initialize model
        }

        public string DisplayMessage
        {
            get { return displayMessage; }
            set
            {
                if (displayMessage != value)
                {
                    displayMessage = value;
                    RaisePropertyChanged();
                }
            }
        }
        public ObservableCollection<string> ItemsCollection
        {
            get { return itemsCollection; }
            set
            {
                if (itemsCollection != value)
                { 
                itemsCollection = value;
                RaisePropertyChanged();
                }
            }
        }

        public EditModel EditModel
        {
            get { return _editModel; }
        }

        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                    addCommand = new Adder();
                return addCommand;
            }
            set { addCommand = value; }
        }

        protected class Adder : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }
            public event EventHandler CanExecuteChanged;
            public void Execute(object parameter)
            {
                // can do this because we did 
                // CommandParameter="{Binding}"
                // with the databinding in our view
                EditViewModel viewModel = (EditViewModel)parameter;
                


                string message = string.Format("Thanks for creating: {0}",
                                               viewModel.EditModel.InputString);

                //ObservableCollection<string> item = new ObservableCollection<string>();
                //item.Add(message);
                //viewModel.ItemsCollection = item;

                //viewModel.ItemsCollection.Add(message);
                viewModel.EditModel.ItemsCollection.

                //viewModel.EditModel.ItemsCollection.Add(message);
                viewModel.DisplayMessage = message;
                

            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
