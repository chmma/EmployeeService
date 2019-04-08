using FluentAssertions;
using NSubstitute;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using EmployeeService.Abstracts;

namespace EmployeeService.Tests
{
    public class WebServiceTests
    {
        private IEnumerable<Employee> employeesEnumerable = new List<Employee>() {
            new Employee
                {
                    Id = 1,
                    FirstName = "Elon",
                    LastName = "Musk"
                },
            new Employee{
                    Id = 2,
                    FirstName = "Steve",
                    LastName = "Jobs"
            }
        };

        [Fact]
        public void GetEmployees_ShouldReturnCollectionOfEmployees()
        {
            var webService = Substitute.For<IWebService<IEnumerable<Employee>>>();
            webService.GetData(Arg.Any<string>()).Returns(employeesEnumerable);

            var employees = webService.GetData("");

            employees.Count().Should().Be(2);
            employees.First().Id.Should().Be(1);
            employees.First().FirstName.Should().Be("Elon");
            employees.First().LastName.Should().Be("Musk");
        }
    }
}
