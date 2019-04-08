using NSubstitute;
using Xunit;
using FluentAssertions;
using EmployeeService.Abstracts;

namespace EmployeeService.Tests
{
    public class HttpClientTests
    {
        private const string jsonData = @"[
  {
    'id': 1,
    'firstName': 'Elon',
    'lastName': 'Musk'
  },
  {
    'id': 2,
    'firstName': 'Steve',
    'lastName': 'Jobs'
  }
]";

        [Fact]
        public async void GetContentAsync_ShouldReturnContent()
        {
            IHttpClient httpClient = Substitute.For<IHttpClient>();
            httpClient.GetContentAsync(Arg.Any<string>()).Returns(jsonData);

            string content = await httpClient.GetContentAsync("");

            content.Should().Be(jsonData);
        }
    }
}
