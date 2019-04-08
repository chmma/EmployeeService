using System.Net.Http;
using System.Threading.Tasks;
using EmployeeService.Abstracts;

namespace EmployeeService
{
    class HttpClientApp : IHttpClient
    {
        private readonly HttpClient httpClient;

        public HttpClientApp(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetContentAsync(string url)
        {
            var response = await httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
