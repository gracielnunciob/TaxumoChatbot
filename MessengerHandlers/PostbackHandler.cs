
using TaxumoChatBot.Handlers;
using Microsoft.Extensions.Logging;

namespace TaxumoChatBot
{
 /*
 * Postback Event
 *
 * This event is called when a postback is tapped on a Structured Message. 
 * https://developers.facebook.com/docs/messenger-platform/webhook-reference/postback-received
 * 
 */
    public class PostbackHandler<T> : IMessengerHandler
    {
        ILogger<T> _logger;
        IMessageSender _messageSender;
        MessageReadHandler<T> _handler;
        public PostbackHandler (ILogger<T> logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }
        public bool MessageHandled(dynamic message)
        {
            var result = message.postback != null;
            if (result)
            {
                string senderID = message.sender.id;
                string recipientID = message.recipient.id;
                string timeOfPostback = message.timestamp;

                // The 'payload' param is a developer-defined field which is set in a postback 
                // button for Structured Messages. 
                var payload = message.postback.payload;
                string pyldText = payload.ToString();

                _logger.LogInformation(
                    string.Format("Received postback for user {0} and page {1} with payload '{2}' " + 
                    "at {3}", senderID, recipientID, pyldText, timeOfPostback));


                if (pyldText == "1") {
                    var flow = new DialogueFlow(senderID);
                    var messageData = flow.GetCaseTwo();
                    _messageSender.CallSendAPI(messageData);
                }
                else if (pyldText == "5")
                {
                    var flow = new DialogueFlow(senderID);
                    var messageData = flow.GetCaseThree();
                    _messageSender.CallSendAPI(messageData);
                }
                else if (pyldText == "6")
                {
                    _messageSender.SendTextMessage(senderID, "Thank you!");
                }

            }
            return result;
        }

    }
}
