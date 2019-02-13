// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace TaxumoChatBot.Api
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Companies.
    /// </summary>
    public static partial class CompaniesExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static IList<CompanyStub> GetCompaniesByUser(this ICompanies operations, string id)
            {
                return operations.GetCompaniesByUserAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<CompanyStub>> GetCompaniesByUserAsync(this ICompanies operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCompaniesByUserWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Company GetCompany(this ICompanies operations, int id)
            {
                return operations.GetCompanyAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Company> GetCompanyAsync(this ICompanies operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCompanyWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='company'>
            /// </param>
            public static Company PutCompany(this ICompanies operations, int id, Company company)
            {
                return operations.PutCompanyAsync(id, company).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='company'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Company> PutCompanyAsync(this ICompanies operations, int id, Company company, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutCompanyWithHttpMessagesAsync(id, company, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Company DeleteCompany(this ICompanies operations, int id)
            {
                return operations.DeleteCompanyAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Company> DeleteCompanyAsync(this ICompanies operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteCompanyWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='user'>
            /// </param>
            /// <param name='company'>
            /// </param>
            public static CompanyStub PostCompany(this ICompanies operations, string user, Company company)
            {
                return operations.PostCompanyAsync(user, company).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='user'>
            /// </param>
            /// <param name='company'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CompanyStub> PostCompanyAsync(this ICompanies operations, string user, Company company, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostCompanyWithHttpMessagesAsync(user, company, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='user'>
            /// </param>
            /// <param name='role'>
            /// </param>
            /// <param name='company'>
            /// </param>
            public static CompanyStub CreateCompanyWithRole(this ICompanies operations, string user, string role, Company company)
            {
                return operations.CreateCompanyWithRoleAsync(user, role, company).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='user'>
            /// </param>
            /// <param name='role'>
            /// </param>
            /// <param name='company'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CompanyStub> CreateCompanyWithRoleAsync(this ICompanies operations, string user, string role, Company company, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateCompanyWithRoleWithHttpMessagesAsync(user, role, company, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Subscription GetSubscription(this ICompanies operations, int id)
            {
                return operations.GetSubscriptionAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Subscription> GetSubscriptionAsync(this ICompanies operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSubscriptionWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}