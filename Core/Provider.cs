namespace Core
{
    public partial class Provider : LocationMessageAgent
    {
        public void Broadcast(Message message)
        {
            var broadcastMessage = new Message(message.From, null, message.Content);
            _messageServer.SendMessage(broadcastMessage);
        }
    }
}