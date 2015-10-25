using Bizmonger.Patterns;

namespace EngageObserver.Confirmation
{
    public partial class ViewModel
    {
        protected override void ActivateCommands()
        {
            ConfirmInteration = new DelegateCommand(obj => ConfirmationRequested = true, CanConfirm);
        }

        public DelegateCommand ConfirmInteration { get; private set; }
    }
}