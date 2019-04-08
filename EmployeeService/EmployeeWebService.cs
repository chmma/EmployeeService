using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeService.Abstracts;

namespace EmployeeService
{
    public class EmployeesWebService : IWebService<Task<IEnumerable<Employee>>>
    {
        private readonly IHttpClient httpClient;
        private readonly IJsonParser<IEnumerable<Employee>> jsonParser;

        public EmployeesWebService(IHttpClient httpClient, IJsonParser<IEnumerable<Employee>> jsonParser)
        {
            this.httpClient = httpClient;
            this.jsonParser = jsonParser;
        }

        public async Task<IEnumerable<Employee>> GetData(string url)
        {
            string employeesJson = await httpClient.GetContentAsync(url);
            return jsonParser.Parse(employeesJson);
        }
    }
}
