using WebApplication1.Controllers;

namespace WebApplication1.Tests;

public class WeatherForecastControllerTests
{
    [Fact]
    public void Get_ShouldReturnFiveForecasts()
    {
        var controller = new WeatherForecastController();

        var result = controller.Get().ToList();

        Assert.Equal(5, result.Count);
        Assert.All(result, item => Assert.NotEqual(default, item.Date));
        Assert.All(result, item => Assert.InRange(item.TemperatureC, -20, 54));
        Assert.All(result, item => Assert.False(string.IsNullOrWhiteSpace(item.Summary)));
    }
}
