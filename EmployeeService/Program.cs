using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeService
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var employeeService = new EmployeesWebService(new HttpClientApp(new HttpClient()),
                new JsonParserApp<IEnumerable<Employee>>());
            var employees = await employeeService.GetData("https://localhost:44346/api/values");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName}");
            }
        }
    }
}
