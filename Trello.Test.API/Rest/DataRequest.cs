using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Trello.Test.API.Rest
{
    public class DataRequest<T> : BaseRequest
    {
        public DataRequest(string uri) : base(uri)
        {

        }
        public async Task<T> Get(string endpoint)
        {
            var response = await SendAsync(RequestMethod.Get, endpoint);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
