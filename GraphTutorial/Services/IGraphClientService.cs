using GraphTutorial.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Graph;

namespace GraphTutorial.Services
{
    public interface IGraphClientService
    {
        GraphServiceClient GetUserGraphClient(
          TokenValidationResult validation,
          string[] scopes,
          ILogger logger);

        GraphServiceClient GetAppGraphClient(ILogger logger);
    }
}