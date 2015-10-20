using Bizmonger.Patterns;

namespace EngageObserver
{
    public partial class ViewModel
    {
        protected override void ActivateCommands()
        {
            SendMessage = new DelegateCommand(OnSendMessage, CanSendMessage);
        }

        public DelegateCommand SendMessage { get; private set; }
    }
}