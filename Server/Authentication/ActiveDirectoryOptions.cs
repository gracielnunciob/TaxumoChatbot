using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxumoChatBot.Authentication
{
	/// <summary>
	/// Options for use with Azure Active Directory B2C
	/// </summary>
    public class ActiveDirectoryOptions
    {
		public const string PolicyAuthenticationProperty = "Policy";

		public ActiveDirectoryOptions()
		{
			AzureAdB2CInstance = "https://login.microsoftonline.com/tfp";
		}

		public string ClientId { get; set; }
		public string AzureAdB2CInstance { get; set; }
		public string Tenant { get; set; }
		public string SignUpSignInPolicyId { get; set; }
		public string SignInPolicyId { get; set; }
		public string SignUpPolicyId { get; set; }
		public string ResetPasswordPolicyId { get; set; }
		public string EditProfilePolicyId { get; set; }
		public string RedirectUri { get; set; }

		public string DefaultPolicy => SignUpSignInPolicyId;
		public string Authority => $"{AzureAdB2CInstance}/{Tenant}/{DefaultPolicy}/v2.0";

		public string ClientSecret { get; set; }
		public string ApiUrl { get; set; }
		public string ApiScopes { get; set; }
	}
}
