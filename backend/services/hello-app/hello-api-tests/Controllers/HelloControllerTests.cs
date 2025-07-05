using FluentAssertions;
using HelloApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace HelloApiTests.Controllers
{
    public class HelloControllerTests
    {
        private readonly HelloController _controller;

        public HelloControllerTests()
        {
            _controller = new HelloController();
        }

        [Fact]
        public void Get_ReturnsOkResult_WithHelloMessage()
        {
            // Act
            var result = _controller.Get() as OkObjectResult;

            // Assert
            result.Should().NotBeNull();
            result.Value.Should().Be("Hello, from platform core!");
        }
    }
}