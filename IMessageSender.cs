using Newtonsoft.Json.Linq;

namespace TaxumoChatBot
{
    public interface IMessageSender
    {
        void SendTextMessage(string senderId, string message);

        void CallSendAPI(JObject messageData);
    }
}