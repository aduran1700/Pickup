using System.Collections.Generic;
using Bizmonger.Patterns;
using Core;
using System.Collections.ObjectModel;

namespace EngageObserver
{
    public sealed partial class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            Provider = new Provider();
            Messages = new ObservableCollection<Message>();
            ActivateCommands();
        }

        public Provider Provider { get; set; }
        public Core.Observer Observer { get; set; }
        public ObservableCollection<Message> Messages { get; set; }
        public Message Message { get; set; }
    }
}