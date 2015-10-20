using System.Collections.ObjectModel;
using Core;

namespace NotifyObservers
{
    public sealed partial class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            ActivateCommands();
        }

        ObservableCollection<Core.Observer> _observers = new ObservableCollection<Core.Observer>();
        public ObservableCollection<Core.Observer> Observers
        {
            get { return _observers; }
            set
            {
                if (_observers != value)
                {
                    _observers = value;
                    OnPropertyChanged();
                }
            }
        }

        Core.Location _location = null;
        public Core.Location Location
        {
            get { return _location; }
            set
            {
                if (_location != value)
                {
                    _location = value;
                    OnPropertyChanged();
                }
            }
        }

        Message _message = null;
        public Message Message
        {
            get { return _message; }
            set
            {
                if (_message != value)
                {
                    _message = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}