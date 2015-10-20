using System.Linq;

namespace NotifyObservers
{
    public partial class ViewModel
    {
        void OnBroadcastLocation(object obj)
        {
            _provider.BroadcastLocation();
            LocationBroadcasted = true;
        }

        void OnBroadcastMessage(object obj)
        {
            _provider.Send(Message);
            MessageBroadcasted = true;
        }

        bool CanBroadcast(object obj)
        {
            if (Observers.Any()) return true;
            return false;
        }
    }
}