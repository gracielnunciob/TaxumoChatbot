using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Microsoft.AspNetCore.Authentication;
using TaxumoChatBot.Controllers;

namespace TaxumoChatBot.Authentication
{
    public class SessionController : Controller
    {
		public ActiveDirectoryOptions AzureAdB2COptions { get; set; }

		public SessionController(IOptions<ActiveDirectoryOptions> b2cOptions)
		{
			AzureAdB2COptions = b2cOptions.Value;
		}

		[HttpGet]
		[Route("signup")]
		public IActionResult SignUp()
		{
			var redirectUrl = "/";
			var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
			properties.Items[ActiveDirectoryOptions.PolicyAuthenticationProperty] = AzureAdB2COptions.SignUpPolicyId;
			return Challenge(properties, OpenIdConnectDefaults.AuthenticationScheme);
		}

		[HttpGet]
        [Route("signin")]
        public IActionResult SignIn()
		{
            var redirectUrl = "/";
			return Challenge(
				new AuthenticationProperties { RedirectUri = redirectUrl },
				OpenIdConnectDefaults.AuthenticationScheme);
		}

		[HttpGet]
        [Route("signout")]
		public IActionResult SignOut()
		{
			var callbackUrl = "https://www.taxumo.com";
			return SignOut(new AuthenticationProperties { RedirectUri = callbackUrl },
				CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme);
		}
	}
}
