using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MvvmSimple2
{
    public class EditModel : INotifyPropertyChanged
    {
        private string _inputString;
        
        private ObservableCollection<string> _itemsCollection;

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
        
        public string InputString
        {
            get { return _inputString; }
            set
            {
                _inputString = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<string> ItemsCollection
        {
            get { return _itemsCollection; }
            set
            {
                _itemsCollection = value;
                RaisePropertyChanged();
            }
        }
    }
}
