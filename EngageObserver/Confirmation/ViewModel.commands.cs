using System;
using Bizmonger.Patterns;

namespace EngageObserver.Confirmation
{
    public partial class ViewModel
    {
        protected override void ActivateCommands()
        {
            InteractionConfirmed = new DelegateCommand(OnInteractionConfirmed, CanConfirm);
        }

        public DelegateCommand InteractionConfirmed { get; private set; }
    }
}