using Newtonsoft.Json;
using EmployeeService.Abstracts;

namespace EmployeeService
{
    public class JsonParserApp<T> : IJsonParser<T>
    {
        public T Parse(string content)
        {
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
