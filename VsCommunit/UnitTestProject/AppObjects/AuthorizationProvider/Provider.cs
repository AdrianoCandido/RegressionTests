using Dlp.Buy4.AuthorizationProvider.Core.Models;
using Dlp.Buy4.AuthorizationProvider.Core.Operations;
using System;
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
        static public event Func<AuthorizationRequest, AuthorizationResponse> InterceptAuthorize;
        static public event Func<CompletionRequest, CompletionResponse> InterceptComplete;
        static public event Func<ReversalRequest, ReversalResponse> InterceptReverse;

        public AuthorizationResponse Authorize(AuthorizationRequest request)
        {
            if (InterceptAuthorize != null)
            {
                return InterceptAuthorize(request);
            }

            return null;
        }

        public CompletionResponse Complete(CompletionRequest request)
        {
            if (InterceptComplete != null)
            {
                return InterceptComplete(request);
            }

            return null;
        }

        public DiagnosticResponse Diagnostic(DiagnosticRequest request)
        {
            return null;
        }

        public ReversalResponse Reverse(ReversalRequest request)
        {
            if (InterceptReverse != null)
            {
                return InterceptReverse(request);
            }
            return null;
        }
    }
}