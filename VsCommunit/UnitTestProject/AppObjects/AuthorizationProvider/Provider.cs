using Dlp.Buy4.AuthorizationProvider.Core.Models;
using Dlp.Buy4.AuthorizationProvider.Core.Operations;
using System.ServiceModel;

namespace Dlp.Buy4.AuthorizationProvider.ServiceLib
{
    /// <summary>
    /// Entry point for the methods exposed the private network.
    /// </summary>
    [ServiceBehavior(Name = "Provider",
        InstanceContextMode = InstanceContextMode.PerCall)]
    public partial class Provider : IProvider
    {
        public static

        public AuthorizationResponse Authorize(AuthorizationRequest request)
        {
            return null;
        }

        public CompletionResponse Complete(CompletionRequest request)
        {
            return null;
        }

        public DiagnosticResponse Diagnostic(DiagnosticRequest request)
        {
            return null;
        }

        public ReversalResponse Reverse(ReversalRequest request)
        {
            return null;
        }
    }
}