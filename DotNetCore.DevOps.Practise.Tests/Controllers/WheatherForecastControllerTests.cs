using DotNetCore.DevOps.Practise.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace DotNetCore.DevOps.Practise.Tests.Controllers
{
    public class WheatherForecastControllerTests
    {
        [Fact]
        public void WhenGetEndpointIsCalled_ShouldReturnWheatherForecasts()
        {
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();

            var controller = new WeatherForecastController(mockLogger.Object);

            var result = controller.Get();

            Assert.NotNull(result);
        }
    }
}