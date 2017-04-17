using Dlp.Buy4.AuthorizationProvider.Core.Models;
using Dlp.Buy4.AuthorizationProvider.Core.Operations;
using System.ServiceModel;

namespace Dlp.Buy4.AuthorizationProvider.ServiceLib
{
    [ServiceContract]
    public interface IProvider
    {
        /// <summary>
        /// Authorizes a transaction.
        /// </summary>
        [FaultContract(typeof(AuthorizationResponse))]
        [OperationContract]
        AuthorizationResponse Authorize(AuthorizationRequest request);

        /// <summary>
        /// Completes a previous transaction.
        /// </summary>
        [FaultContract(typeof(CompletionResponse))]
        [OperationContract]
        CompletionResponse Complete(CompletionRequest request);

        /// <summary>
        /// Reverses a previous transaction.
        /// </summary>
        [FaultContract(typeof(ReversalResponse))]
        [OperationContract]
        ReversalResponse Reverse(ReversalRequest request);

        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [OperationContract]
        DiagnosticResponse Diagnostic(DiagnosticRequest request);
    }
}