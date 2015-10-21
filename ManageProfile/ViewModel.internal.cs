using static Mediation.Messages;
using static Bizmonger.Patterns.MessageBus;
using Core;

namespace ManageProfile
{
    public partial class ViewModel
    {
        public void SendRequests()
        {
            Subscribe(REQUEST_PROFILE_RESPONSE, OnProfileResponse);
            Publish(REQUEST_PROFILE);
        }

        void OnProfileResponse(object obj)
        {
            _profile = obj as Profile;
            Alias = _profile.Alias;
        }

        void OnSave(object obj)
        {
            
        }

        bool CanSave(object obj)
        {
            return true;
        }
    }
}