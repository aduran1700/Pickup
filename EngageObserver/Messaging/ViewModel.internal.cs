using Core;
using System.Collections.Generic;

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
    }
}