using Dlp.Buy4.AuthorizationProvider.Core.Operations;
using Dlp.Buy4.AuthorizationProvider.ServiceLib;
using PoiServiceRegressionTests.AppObjects.DataContracts.PoiService;
using System;

namespace UnitTestProject1.Tests
{
    public class BaseAuthorization
    {
        public SimpleAuthorizationRequest Request { get; set; }

        public AuthorizationResponse ProviderResponse = new AuthorizationResponse()
        {
            AcquirerDateTime = DateTime.UtcNow,
            ActionCode = "0000",
            AmountAuthorized = 1,
            AmountOriginal = 1,
            AquirerTransactionKey = "11111111111111",
            AuthorizationId = "12322",
            BalanceAmount = 1,
            IccRelatedData = "111111",
            IsPartial = false,
            PaymentSchemeId = 1,
            Success = true
        };

        public BaseAuthorization()
        {
            Request = new SimpleAuthorizationRequest();
            Provider.InterceptAuthorize = ProvideInterceptAuthorize;
        }

        private AuthorizationResponse ProvideInterceptAuthorize(AuthorizationRequest arg)
        {
            return ProviderResponse;
        }
    }
}