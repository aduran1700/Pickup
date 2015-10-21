using Core;
using System.Collections.ObjectModel;

namespace EngageObserver.Message
{
    public sealed partial class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            Provider = new Provider();
            Messages = new ObservableCollection<Core.Message>();
            ActivateCommands();
            SendRequests();
        }

        public Provider Provider { get; set; }
        public Core.Observer Observer { get; set; }
        public ObservableCollection<Core.Message> Messages { get; set; }
        public Core.Message Message { get; set; }
    }
}