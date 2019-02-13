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
    /// Extension methods for VatExpenses.
    /// </summary>
    public static partial class VatExpensesExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='company'>
            /// </param>
            /// <param name='year'>
            /// </param>
            /// <param name='month'>
            /// </param>
            /// <param name='quarter'>
            /// </param>
            public static IList<VatExpense> GetVatExpenses(this IVatExpenses operations, int company, int year, int? month = default(int?), int? quarter = default(int?))
            {
                return operations.GetVatExpensesAsync(company, year, month, quarter).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='company'>
            /// </param>
            /// <param name='year'>
            /// </param>
            /// <param name='month'>
            /// </param>
            /// <param name='quarter'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VatExpense>> GetVatExpensesAsync(this IVatExpenses operations, int company, int year, int? month = default(int?), int? quarter = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetVatExpensesWithHttpMessagesAsync(company, year, month, quarter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='company'>
            /// </param>
            /// <param name='year'>
            /// </param>
            /// <param name='quarter'>
            /// </param>
            /// <param name='month'>
            /// </param>
            public static IList<VatExpense> GetVatExpenses1(this IVatExpenses operations, int company, int year, int quarter, int? month = default(int?))
            {
                return operations.GetVatExpenses1Async(company, year, quarter, month).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='company'>
            /// </param>
            /// <param name='year'>
            /// </param>
            /// <param name='quarter'>
            /// </param>
            /// <param name='month'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VatExpense>> GetVatExpenses1Async(this IVatExpenses operations, int company, int year, int quarter, int? month = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetVatExpenses1WithHttpMessagesAsync(company, year, quarter, month, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='company'>
            /// </param>
            /// <param name='year'>
            /// </param>
            /// <param name='month'>
            /// </param>
            /// <param name='quarter'>
            /// </param>
            public static IList<VatExpense> GetVatExpenses2(this IVatExpenses operations, int company, int year, int month, int? quarter = default(int?))
            {
                return operations.GetVatExpenses2Async(company, year, month, quarter).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='company'>
            /// </param>
            /// <param name='year'>
            /// </param>
            /// <param name='month'>
            /// </param>
            /// <param name='quarter'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VatExpense>> GetVatExpenses2Async(this IVatExpenses operations, int company, int year, int month, int? quarter = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetVatExpenses2WithHttpMessagesAsync(company, year, month, quarter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expense'>
            /// </param>
            public static VatExpense PostVatExpense(this IVatExpenses operations, VatExpense expense)
            {
                return operations.PostVatExpenseAsync(expense).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expense'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VatExpense> PostVatExpenseAsync(this IVatExpenses operations, VatExpense expense, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostVatExpenseWithHttpMessagesAsync(expense, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='expense'>
            /// </param>
            public static VatExpense PutExpense(this IVatExpenses operations, int id, VatExpense expense)
            {
                return operations.PutExpenseAsync(id, expense).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='expense'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VatExpense> PutExpenseAsync(this IVatExpenses operations, int id, VatExpense expense, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutExpenseWithHttpMessagesAsync(id, expense, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static VatExpense DeleteExpense(this IVatExpenses operations, int id)
            {
                return operations.DeleteExpenseAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VatExpense> DeleteExpenseAsync(this IVatExpenses operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteExpenseWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expense'>
            /// </param>
            public static bool? BulkPostExpense(this IVatExpenses operations, IList<VatExpense> expense)
            {
                return operations.BulkPostExpenseAsync(expense).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expense'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> BulkPostExpenseAsync(this IVatExpenses operations, IList<VatExpense> expense, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BulkPostExpenseWithHttpMessagesAsync(expense, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
