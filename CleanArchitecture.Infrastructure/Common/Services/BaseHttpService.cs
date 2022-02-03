using CleanArchitecture.SharedLibrary.Http.Exceptions;

namespace CleanArchitecture.Infrastructure.Common.Services
{
    public class BaseHttpService
    {
        protected HttpClient HttpClient;
        public BaseHttpService(HttpClient httpClient)        {
            HttpClient = httpClient;
        }

        protected HttpRequestMessage GenerateHttpRequest(HttpMethod method,
          string requestUri, HttpContent content = default(HttpContent))
        {
            return new HttpRequestMessage(method, requestUri)
            {
                Content = content
            };
        }

        protected async Task<HttpResponseMessage> MakeRequest(HttpRequestMessage request)
        {
            HttpResponseMessage responseMessage;
            try
            {
                responseMessage = await HttpClient.SendAsync(request);

                if (!responseMessage.IsSuccessStatusCode)
                {
                    var statusCode = (int)responseMessage.StatusCode;
                    throw new ApiException($"API Error occured with status code: {statusCode}",
                        statusCode, responseMessage.Content);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured before sending API request", ex);
            }

            return responseMessage;
        }
    }
}
