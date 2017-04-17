using Buy4.Services.Sdk.Models.Poi;
using PoiServiceRegressionTests.AppObjects.DataContracts.PoiService;
using PoiServiceRegressionTests.AppObjects.Serialization;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace PoiServiceRegressionTests.AppObjects.Communication
{
    public static class HttpRequester
    {
        private static string baseRequest = "http://localhost:8087/";

        public static HttpEnvelop<SimpleAuthorizationResponse> Post(SimpleAuthorizationRequest request)
        {
            var result = Post<AcceptorAuthorisationResponse>(RequestFactory.CreateAuthorizationRequest(request), baseRequest + "Authorize");

            return new HttpEnvelop<SimpleAuthorizationResponse>()
            {
                Content = RequestFactory.CreateResponse(result.Content),
                HttpHeaders = result.HttpHeaders,
                StatusCode = result.StatusCode
            };
        }

        public static HttpEnvelop<T> Post<T>(object request, string uri)
        {
            HttpClient client = new HttpClient();

            HttpRequestMessage message = new HttpRequestMessage();

            string xml = XSerializer.Serialize(request);

            message.Content = new StringContent(xml, Encoding.UTF8, "application/xml");
            message.Method = HttpMethod.Post;
            message.RequestUri = new System.Uri(uri);

            HttpEnvelop<T> responseEnvelop = new HttpEnvelop<T>();
            HttpResponseMessage responseMessage = client.SendAsync(message).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                string contentResult = responseMessage.Content.ReadAsStringAsync().Result;

                responseEnvelop.Content = XSerializer.Deserialize<T>(contentResult);
                responseEnvelop.StatusCode = responseMessage.StatusCode;
                responseEnvelop.HttpHeaders = responseMessage.Headers;
            }

            return responseEnvelop;
        }

        private static byte[] GetBytes(string data)
        {
            byte[] buffer = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                byte[] result = BitConverter.GetBytes(data[i]);
                buffer[i] = result[0];
            }
            return buffer;
        }
    }

    public class HttpEnvelop<T>
    {
        public T Content { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public HttpHeaders HttpHeaders { get; set; }
    }
}