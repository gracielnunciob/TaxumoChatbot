using Newtonsoft.Json.Linq;
using System;
using TaxumoChatBot.Handlers;

namespace TaxumoChatBot.Handlers{

  

    public class DialogueFlow
    {

        private JObject CaseOne;
        private JObject CaseTwo;
        private JObject CaseThree;
        private JObject SuccessCase;


        public DialogueFlow(string recipientId)
        {
            setCaseOne(recipientId);
            setCaseTwo(recipientId);
            setCaseThree(recipientId);
            setSuccessCase(recipientId);
        }

        private void setCaseOne(string recipientId) {
            CaseOne = JObject.FromObject(new
            {
                recipient = new
                {
                    id = recipientId
                },
                message = new
                {
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "button",
                            text = "Hi! Welcome to Taxumo! Im Taxubot! What do you want to do?",
                            buttons = new dynamic[]{
                                    new {
                                        type= "web_url",
                                        url= " https://intercom.help/taxumo-inc",
                                        title= "FAQ page"
                                    },
                                    new {
                                        type= "postback",
                                        title= "Submit Reciept",
                                        payload= "1"
                                    },
                               }
                        }
                    }
                }
            }
            );
        }
        private void setCaseTwo(string recipientId)
        {
            CaseTwo = JObject.FromObject(new
            {
                recipient = new { id = recipientId },
                message = new
                {
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "button",
                            text = "Are you a registered user?",
                            buttons = new dynamic[]{
                                    new {
                                        type= "web_url",
                                        url= " http://7282425e.ngrok.io",
                                        title= "No"
                                    },
                                    new {
                                        type= "account_link",
                                        url= "http://8b7d0064.ngrok.io/login",
                                       
                                    },
                               }
                        }
                    }
                }
            }
            );
        }
        private void setCaseThree(string recipientId)
        {
            CaseThree = JObject.FromObject(new
            {
                recipient = new { id = recipientId },
                message = new
                {
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "button",
                            text = "Do you have a reciept?",
                            buttons = new dynamic[]{
                                   new {
                                        type= "postback",
                                        title= "Nope",
                                        payload= "5"
                                    },
                                   new {
                                        type= "web_url",
                                        url= "http://8b7d0064.ngrok.io",
                                        title= "Yes I do"
                                    },
                               }
                        }
                    }
                }
            }
            );
        }
        private void setSuccessCase(string recipientId)
        {
            SuccessCase = JObject.FromObject(new
            {
                recipient = new { id = recipientId },
                message = new
                {
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "button",
                            text = "Success! Do you want to submit another one?",
                            buttons = new dynamic[]{
                                   new {
                                        type= "postback",
                                        title= "No thanks!",
                                        payload= "6"
                                    },
                                   new {
                                        type= "web_url",
                                        url= "http://8b7d0064.ngrok.io",
                                        title= "Yes I do"
                                    },
                               }
                        }
                    }
                }
            }
            );
        }

        public JObject GetCaseOne()
        {
            return CaseOne;
        }
        public JObject GetCaseTwo()
        {
            return CaseTwo;
        }
        public JObject GetCaseThree()
        {
            return CaseThree;
        }
        public JObject GetSuccessCase()
        {
            return SuccessCase;
        }

    }
}
