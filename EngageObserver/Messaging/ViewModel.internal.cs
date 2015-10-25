using System.Collections.Generic;
using Core;
using static Bizmonger.Patterns.MessageBus;
using static Mediation.Messages;

namespace EngageObserver.Message
{
    public partial class ViewModel
    {
        void OnSendMessage(object obj)
        {
            if (Message == null) Message = new Core.Message(Provider.Id, new List<string>() { Observer.Id }, "some_message");
            Provider.Send(Message);
        }

        bool CanSendMessage(object obj)
        {
            return false;
        }

        public void SendRequests()
        {
            Subscribe(OBSERVER_TO_MESSAGE, obj => Observer = obj as Observer);
        }
    }
}