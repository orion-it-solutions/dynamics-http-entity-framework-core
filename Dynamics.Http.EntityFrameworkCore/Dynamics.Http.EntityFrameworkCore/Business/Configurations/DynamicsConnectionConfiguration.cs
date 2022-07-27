using System.Net.Http.Headers;
using Microsoft.Identity.Client;
using Microsoft.Extensions.DependencyInjection;
using Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Context;

namespace Dynamics.Http.EntityFrameworkCore.Business.Configurations
{
    public class DynamicsConnectionConfiguration
    {
        private readonly DynamicsContextOptions _options;

        protected readonly HttpClient _dynamicsClientConnector;

        public DynamicsConnectionConfiguration(DynamicsContextOptions options)
        {
            _options = options;
            var serviceCollection = ConfigureServices();
            var services = serviceCollection.BuildServiceProvider();
            var clientFactory = services.GetRequiredService<IHttpClientFactory>();
            _dynamicsClientConnector = clientFactory.CreateClient("DynamicsClient");
        }

        private async Task<string> GetAuthorizationToken()
        {
            try
            {
                var app = ConfidentialClientApplicationBuilder.Create(_options.Connection.ClientId)
                    .WithAuthority(AzureCloudInstance.AzurePublic, _options.Connection.TenantId)
                    .WithClientSecret(_options.Connection.ClientSecret)
                    .Build();
                var acquireToken = await app.AcquireTokenForClient(new string[] { $"{ _options.Connection.Resource }/.default" }).ExecuteAsync();
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
                options.BaseAddress = new Uri($"{ _options.Connection.Resource }/api/data/v{ _options.Connection.Version ?? "9.2" }/");
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
