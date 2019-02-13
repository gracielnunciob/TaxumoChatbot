using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TaxumoChatBot.Api.Models;

namespace TaxumoChatBot.Upe
{
    public static class TaxumoUpeClient
    {

        /// <summary>
        /// The URL of the Taxumo API instance corresponding the current environment.
        /// </summary>
        static string taxumoupe_url = Program.Configuration["TAXUMOUPE_URL"];

        /// <summary>
        /// Utility function for instantiating the <see cref="TaxumoUpe"/> targeting the Taxumo API
        /// instance for the current environment, decorated with the appropriate bearer access token.
        /// </summary>
        /// <returns>An instance of <see cref="TaxumoUpe"/></returns>
        public async static Task<TaxumoUpe> CreateClientAsync()
        {
            var client = new TaxumoUpe(new System.Uri(taxumoupe_url));

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
    }
}