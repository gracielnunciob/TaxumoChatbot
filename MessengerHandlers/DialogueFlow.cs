using Newtonsoft.Json.Linq;
using System;
using TaxumoChatBot.Handlers;

namespace TaxumoChatBot.Handlers{

  

    public class DialogueFlow
    {
        private MessengerSettings Settings { get; set; }
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
                                        url= "https://login.microsoftonline.com/te/taxumoapp.onmicrosoft.com/b2c_1_su/oauth2/v2.0/authorize?client_id=45cd44fe-3e8e-495f-bfc1-f3127c86854b&redirect_uri=https%3A%2F%2Fapp.taxumo.com%2Fsignin-oidc&response_type=id_token&scope=openid%20profile&response_mode=form_post&nonce=636850976835039718.MjQzYmVkYmUtMmI1Zi00NjRiLTgwYWItMzEzOTVhY2E4MjYzMWFlODE1YjktMDVlMC00YTZhLWFkOGYtOTI3YjE1YjY3MTE1&state=CfDJ8F4WXZoBpZhAmXTOi_OnBztO75-FVMunRLhK-li_eDUsUUQHFRH-OZRTCON9a_nfvpWmMdixWUvMYuwW6IhEt5nUE75Z-tM3r78IECY2NJxcWSECH8MMNjt2D-Z1s9jfOgtcKTuwXA9oMQIcNBbqLDuVQlW7tzVKwtZfAU_pjBA9Ek5ZdP5Mqg_OhRjCQP6F0csD81u71VnhSXUWJbFxHt6igrJPJ1rweOggS1EP_LHPts8ZewbmReDg684MNe1dAf0OhcCq16K5PkNAQm4-Eh-LyYE_p1nb_y_sVIGOOLUB&x-client-SKU=ID_NET&x-client-ver=2.1.4.0",
                                        title= "No"
                                    },
                                    new {
                                        type= "account_link",
                                        url=  "https://829b6bee.ngrok.io/authorize",
                                       
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
                                        type= "account_link",
                                        url= " https://829b6bee.ngrok.io/upload",
                                     
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
                                        type= "postback",
                                        title= "Yes",
                                        payload= "5"
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
