using System.Threading.Tasks;

namespace EmployeeService.Abstracts
{
    public interface IHttpClient
    {
        Task<string> GetContentAsync(string url);
    }
}
