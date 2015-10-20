using Bizmonger.Patterns;

namespace NotifyObservers
{
    public partial class ViewModel
    {
        public DelegateCommand BroadcastLocation { get; private set; }
        public DelegateCommand BroadcastMessage { get; private set; }

        protected override void ActivateCommands()
        {
            BroadcastLocation = new DelegateCommand(OnBroadcastLocation, CanBroadcast);
            BroadcastMessage = new DelegateCommand(OnBroadcastMessage, CanBroadcast);
        }
    }
}