using FluentAssertions;
using NSubstitute;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using EmployeeService.Abstracts;

namespace EmployeeService.Tests
{
    public class JsonParserTests
    {
        private IEnumerable<Employee> employeeCollection = new List<Employee>() {
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
        public void Parse_ShouldReturnCollectionOfEmployees()
        {
            var employeeParser = Substitute.For<IJsonParser<IEnumerable<Employee>>>();
            employeeParser.Parse(Arg.Any<string>()).Returns(employeeCollection);

            var employees = employeeParser.Parse("");

            employees.Count().Should().Be(2);
            employees.First().Id.Should().Be(1);
            employees.First().FirstName.Should().Be("Elon");
            employees.First().LastName.Should().Be("Musk");
        }
    }
}
