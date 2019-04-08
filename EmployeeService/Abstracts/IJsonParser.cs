namespace EmployeeService.Abstracts
{
    public interface IJsonParser<T>
    {
        T Parse(string content);
    }
}
