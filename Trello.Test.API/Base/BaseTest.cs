using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Trello.Test.API.Rest;

namespace Trello.Test.API.Base
{
    public class BaseTest
    {
        public ServiceProvider ServiceProvider { get; }

        public BaseTest()
        {
            var services = new ServiceCollection().AddTransient<IConfiguration>(sp => new ConfigurationBuilder().AddJsonFile("appsettings.json").Build());

            ServiceProvider = services.BuildServiceProvider();
            var config = ServiceProvider.GetService<IConfiguration>();

            Endpoints.BaseURI = config["Settings:BaseURI"];
            Endpoints.Cep = config["Settings:Cep"];
        }


        protected static async Task<T> Get<T>(string baseUri, string endpoint)
        {   
            var request = new DataRequest<T>(baseUri);
            var result = await request.Get(endpoint);

            return result;
        }

    }
}
