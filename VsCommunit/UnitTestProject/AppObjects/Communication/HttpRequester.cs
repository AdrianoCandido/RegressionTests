using Buy4.Services.Sdk.Models.Poi;
using PoiServiceRegressionTests.AppObjects.DataContracts.PoiService;
using PoiServiceRegressionTests.AppObjects.Serialization;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace PoiServiceRegressionTests.AppObjects.Communication
{
    public static class HttpRequester
    {
        private static Uri baseUri = new Uri(ConfigurationManager.AppSettings["ServiceEndPoint"]);

        public static HttpEnvelop<SimpleAuthorizationResponse> Post(SimpleAuthorizationRequest request)
        {
            var result = Post<AcceptorAuthorisationResponse>(RequestFactory.CreateAuthorizationRequest(request), new Uri(baseUri, "Authorize"));

            return new HttpEnvelop<SimpleAuthorizationResponse>()
            {
                Content = RequestFactory.CreateAuthorizationResponse(result.Content),
                HttpHeaders = result.HttpHeaders,
                StatusCode = result.StatusCode
            };
        }

        public static HttpEnvelop<T> Post<T>(object request, Uri uri)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage httpMessage = new HttpRequestMessage();

                string xml = XSerializer.Serialize(request);

                httpMessage.Content = new StringContent(xml, Encoding.UTF8, "application/xml");
                httpMessage.Method = HttpMethod.Post;
                httpMessage.RequestUri = uri;

                HttpResponseMessage responseMessage = client.SendAsync(httpMessage).Result;

                return new HttpEnvelop<T>()
                {
                    Content = XSerializer.Deserialize<T>(responseMessage.Content.ReadAsStringAsync().Result),
                    StatusCode = responseMessage.StatusCode,
                    HttpHeaders = responseMessage.Headers
                };
            }
        }
    }

    public class HttpEnvelop<T>
    {
        public T Content { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public HttpHeaders HttpHeaders { get; set; }
    }
}