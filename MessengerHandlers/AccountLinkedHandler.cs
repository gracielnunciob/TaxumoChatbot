using TaxumoChatBot.Handlers;
using Microsoft.Extensions.Logging;

namespace TaxumoChatBot
{
    /*
    * Account Link Event
    *
    * This event is called when the Link Account or UnLink Account action has been
    * tapped.
    * https://developers.facebook.com/docs/messenger-platform/webhook-reference/account-linking
    * 
    */
    public class AccountLinkedHandler<T> : IMessengerHandler
    {
        IMessageSender _messageSender;

        ILogger<T> _logger;
        public AccountLinkedHandler (ILogger<T> logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;

        }
        public bool MessageHandled(dynamic message)
        {
            var result = message.account_linking != null;
            if (result)
            {
                string senderID = message.sender.id;
                var recipientID = message.recipient.id;

                string status = message.account_linking.status;
                string authCode = message.account_linking.authorization_code;

                _logger.LogInformation(
                    string.Format("Received account link event with for user {0} with status {1} " +
                "and auth code {2} ", senderID, status, authCode));

                if (authCode == "1")
                {
                    var flow = new DialogueFlow(senderID);
                    var messageData = flow.GetCaseThree();
                    _messageSender.CallSendAPI(messageData);
                }

                else if (authCode == "2")
                {
                    var flow = new DialogueFlow(senderID);
                    var messageData = flow.GetSuccessCase();
                    _messageSender.CallSendAPI(messageData);
                }



            }
            return result;
        }

    }
}
