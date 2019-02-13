// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace TaxumoChatBot.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Orders.
    /// </summary>
    public static partial class OrdersExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='companyId'>
            /// </param>
            public static Order GetLastOrder(this IOrders operations, int companyId)
            {
                return operations.GetLastOrderAsync(companyId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='companyId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Order> GetLastOrderAsync(this IOrders operations, int companyId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLastOrderWithHttpMessagesAsync(companyId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='paymentId'>
            /// </param>
            public static Order GetOrderWithPaymentReference(this IOrders operations, int paymentId)
            {
                return operations.GetOrderWithPaymentReferenceAsync(paymentId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='paymentId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Order> GetOrderWithPaymentReferenceAsync(this IOrders operations, int paymentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOrderWithPaymentReferenceWithHttpMessagesAsync(paymentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderRequest'>
            /// </param>
            public static object PostOrder(this IOrders operations, Order orderRequest)
            {
                return operations.PostOrderAsync(orderRequest).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostOrderAsync(this IOrders operations, Order orderRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostOrderWithHttpMessagesAsync(orderRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// </param>
            /// <param name='paymentId'>
            /// </param>
            public static Order SettleOrder(this IOrders operations, System.Guid orderId, int paymentId)
            {
                return operations.SettleOrderAsync(orderId, paymentId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// </param>
            /// <param name='paymentId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Order> SettleOrderAsync(this IOrders operations, System.Guid orderId, int paymentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SettleOrderWithHttpMessagesAsync(orderId, paymentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// </param>
            public static object CancelOrder(this IOrders operations, System.Guid orderId)
            {
                return operations.CancelOrderAsync(orderId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> CancelOrderAsync(this IOrders operations, System.Guid orderId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelOrderWithHttpMessagesAsync(orderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='companyId'>
            /// </param>
            public static object SetupTrial(this IOrders operations, int companyId)
            {
                return operations.SetupTrialAsync(companyId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='companyId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> SetupTrialAsync(this IOrders operations, int companyId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SetupTrialWithHttpMessagesAsync(companyId, null, cancellationToken).ConfigureAwait(false))
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
            public static object VerifyTrialEligibility(this IOrders operations, string user, int company)
            {
                return operations.VerifyTrialEligibilityAsync(user, company).GetAwaiter().GetResult();
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
            public static async Task<object> VerifyTrialEligibilityAsync(this IOrders operations, string user, int company, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.VerifyTrialEligibilityWithHttpMessagesAsync(user, company, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
