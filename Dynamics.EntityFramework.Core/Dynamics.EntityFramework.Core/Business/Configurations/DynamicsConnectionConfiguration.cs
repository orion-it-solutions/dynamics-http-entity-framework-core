using System.Net.Http.Headers;
using Microsoft.Identity.Client;
using Microsoft.Extensions.DependencyInjection;
using Dynamics.EntityFramework.Core.Infrastructure.ContextConfiguration;


namespace Dynamics.EntityFramework.Core.Business.Configurations
{
    public class DynamicsConnectionConfiguration
    {        
        private readonly DynamicsConnection _connection;

        protected readonly HttpClient _dynamicsClientConnector;

        public DynamicsConnectionConfiguration(DynamicsConnection connection)
        {
            _connection = connection;
            var serviceCollection = ConfigureServices();
            var services = serviceCollection.BuildServiceProvider();
            var clientFactory = services.GetRequiredService<IHttpClientFactory>();
            _dynamicsClientConnector = clientFactory.CreateClient("DynamicsClient");
        }

        private async Task<string> GetAuthorizationToken()
        {
            try
            {
                var app = ConfidentialClientApplicationBuilder.Create(_connection.ClientId)
                    .WithAuthority(AzureCloudInstance.AzurePublic, _connection.TenantId)
                    .WithClientSecret(_connection.ClientSecret)
                    .Build();
                var acquireToken = await app.AcquireTokenForClient(new string[] { $"{ _connection.Resource }/.default" }).ExecuteAsync();
                return acquireToken.AccessToken;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private ServiceCollection ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddHttpClient("DynamicsClient", async options =>
            {
                options.BaseAddress = new Uri($"{ _connection.Resource }/api/data/v{ _connection.Version ?? "9.2" }/");
                options.Timeout = new TimeSpan(0, 2, 0);
                options.DefaultRequestHeaders.Add("OData-Version", "4.0");
                options.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                options.DefaultRequestHeaders.Add("Prefer", "odata.include-annotations=\"OData.Community.Display.V1.FormattedValue\"");
                options.DefaultRequestHeaders.Add("Accept", "application/json");
                options.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", await GetAuthorizationToken());
            });
            return serviceCollection;
        }
    }
}
