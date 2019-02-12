using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Encodings.Web;

namespace TaxumoChatBot.Controllers
{

    
    public class WebappController : Controller
    {
        /*
        * This path is used for account linking. The account linking call-to-action
        * (sendAccountLinking) is pointed to this URL. 
        * 
        */
        [HttpGet]
        [Route("/authorize")]

        public ViewResult Login()
        {
            // Authorization Code should be generated per user by the developer. This will 
            // be passed to the Account Linking callback.\

        

            ViewBag.AccountLinkingToken = Request.Query["account_linking_token"];
            ViewBag.RedirectURI = Request.Query["redirect_uri"];
            // Redirect users to this URI on successful login
            //ViewBag.RedirectURISuccess = ViewBag.RedirectURI + "&authorization_code=" + authCode;

            return View();
        }
        [HttpPost]
        [Route("/authorize/verify")]
        public IActionResult Login(string redirectURI,string email, string tinNo) {

            Random rnd = new Random();


            var  authCode = rnd.Next(0                                                                                                                           , 10000).ToString() + "1" ;

            string Email = email;
            string TinNo = tinNo;

            return Redirect(redirectURI+ "&authorization_code=" + authCode);
        }
        [HttpGet]
        [Route("/upload")]
        public ViewResult Upload()
        {
            // Authorization Code should be generated per user by the developer. This will 
            // be passed to the Account Linking callback.\

            var authCode = "2";


            ViewBag.fbAccountLinkingToken = Request.Query["account_linking_token"];
            ViewBag.RedirectURI = Request.Query["redirect_uri"];
            // Redirect users to this URI on successful login
            ViewBag.RedirectURISuccess = ViewBag.RedirectURI + "&authorization_code=" + authCode;

            return View();
        }
    }
}
