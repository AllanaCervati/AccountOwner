using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILoggerManager _logger;

    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        _logger.LogInfo("testando o log de info");
        _logger.LogDebug("testando o log de Debug");
        _logger.LogError("testando o log de Erro");
        _logger.LogWarn("testando o log de aviso");
        return new string[]
        {
            "value1",
            "value2"
        };
    }
}
