using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using TaxumoChatbot;
using TaxumoChatBot.Api.Models;

namespace TaxumoChatBot.Api
{
	public class TaxumoApiClient
	{
        private readonly IConfiguration Configuration;
        public TaxumoApiClient(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        /// <summary>
        /// The URL of the Taxumo API instance corresponding the current environment.
        /// </summary>
        string taxumoapi_url = Configuration["TAXUMOAPI_URL"];

		/// <summary>
		/// Utility function for instantiating the <see cref="TaxumoApi"/> targeting the Taxumo API
		/// instance for the current environment, decorated with the appropriate bearer access token.
		/// </summary>
		/// <returns>An instance of <see cref="TaxumoApi"/></returns>
		public async Task<TaxumoApi> CreateClientAsync()
		{
			var client = new TaxumoApi(new System.Uri(taxumoapi_url));

			try
			{
				var token = (await ServicePrincipal.GetAccessTokenAsync()).AccessToken;
				client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            catch (System.Exception) { }

            try
            {
                HttpContextAccessor httpContextAccessor = new HttpContextAccessor();
                var company = httpContextAccessor.HttpContext.Session.Get<CompanyStub>("ActiveCompany").Id;
                var user = httpContextAccessor.HttpContext.Session.Get<string>("ActiveUserId");
                var customHeader = string.Format("{0},{1}", company, user);
                client.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("X-User", customHeader);
            }
            catch (System.Exception) { }

            return client;
		}

        public class Iconfiguration
        {
        }
    }
}