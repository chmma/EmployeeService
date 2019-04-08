namespace EmployeeService.Abstracts
{
    public interface IWebService<T>
    {
        T GetData(string url);
    }
}
