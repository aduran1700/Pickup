using Core;
using static Bizmonger.Patterns.MessageBus;
using static Mediation.Messages;

namespace EngageObserver.Confirmation
{
    public sealed partial class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            Subscribe(CONFIRM_INTERACTION, obj => Observer = obj as Observer);
        }
        public bool ConfirmationRequested { get; set; }
        public Core.Observer Observer { get; set; }
    }
}