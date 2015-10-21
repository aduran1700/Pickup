using Bizmonger.Patterns;
using static Bizmonger.Patterns.MessageBus;
using static Mediation.Messages;

namespace ViewMenu
{
    public partial class ViewModel
    {
        public DelegateCommand ViewProfile { get; private set; }
        public DelegateCommand ComposeMessage { get; private set; }
        public DelegateCommand RequestConfirmation { get; private set; }

        protected override void ActivateCommands()
        {
            ViewProfile = new DelegateCommand(obj => Publish(REQUEST_VIEW_PROFILE));
            ComposeMessage = new DelegateCommand(obj => Publish(REQUEST_VIEW_MESSENGER));
            RequestConfirmation = new DelegateCommand(obj => Publish(REQUEST_VIEW_CONFIRM_INTERACTION));
        }
    }
}