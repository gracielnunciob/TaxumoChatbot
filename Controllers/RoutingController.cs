using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Text;



namespace Router.Controllers{

    public class Routes : Controller
    {
         private var _verifytoken = "taxumoizdabest";
         private var _pageToken = "temp";
         private var _appSecret = "temp1";        
        public IActionResult Index()
        {
            return Ok("hi there");
        }
        // HTTP Get endpoint to verify Webhook using the Verify Token
        [Route("webhook")]
        [HttpGet]
        public HttpResponseMessage Verify()
        {
            var querystrings = Request.GetQueryNameValuePairs().ToDictionary(x => x.Key, x => x.Value);

            Bot.Messenger.MessengerPlatform bot = Bot.Messenger.MessengerPlatform.CreateInstance(
                    Bot.Messenger.MessengerPlatform.CreateCredentials(_appSecret, _pageToken, _verifytoken));

            if (bot.Authenticator.VerifyToken(querystrings["hub.verify_token"]))
            {
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(querystrings["hub.challenge"], Encoding.UTF8, "text/plain")
                };
            }

            return new HttpResponseMessage(HttpStatusCode.Unauthorized);
        }

        // HTTP Post endpoint to receive Webhook callbacks from Facebook Messenger
        [Route("webhook")]
        [HttpPost]
        public async Task<HttpResponseMessage> Post()
        {
            var body = await Request.Content.ReadAsStringAsync();

            Bot.Messenger.MessengerPlatform bot = Bot.Messenger.MessengerPlatform.CreateInstance(
                    Bot.Messenger.MessengerPlatform.CreateCredentials(_appSecret, _pageToken, _verifyToken));

            if (!bot.Authenticator.VerifySignature(Request.Headers.GetValues("X-Hub-Signature").FirstOrDefault(), body))
                return new HttpResponseMessage(HttpStatusCode.BadRequest);

            Bot.Messenger.Models.WebhookModel webhookModel = bot.ProcessWebhookRequest(body);

            foreach (var entry in webhookModel.Entries)
            {
                foreach (var evt in entry.Events)
                {                
                    if (evt.EventType == Bot.Messenger.Models.WebhookEventType.MessageReceivedCallback)
                    {
                        await bot.SendApi.SendActionAsync(evt.Sender.ID, Bot.Messenger.Models.SenderAction.typing_on);

                        Bot.Messenger.Models.UserProfileResponse userProfileRsp = await bot.UserProfileApi.GetUserProfileAsync(evt.Sender.ID);

                        if (evt.Message.Attachments == null)
                        {
                                await bot.SendApi.SendTextAsync(evt.Sender.ID, $"Hello {userProfileRsp?.FirstName} :)");
                        }
                        else // if the user sent an image, file, sticker etc., we send it back to them
                        {
                                foreach (var attachment in evt.Message.Attachments)
                                {
                                    if (attachment.Type != Bot.Messenger.Models.AttachmentType.fallback
                                        && attachment.Type != Bot.Messenger.Models.AttachmentType.location)
                                    {
                                        await bot.SendApi.SendTextAsync(evt.Sender.ID, $"Hello {userProfileRsp?.FirstName}, you sent this and we thought it would be nice we sent it back :)");

                                        await bot.SendApi.SendAttachmentAsync(evt.Sender.ID, attachment);
                                    }
                                }
                        }
                    }
                }
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }

}