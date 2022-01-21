using System.Threading.Tasks;
using Trello.Test.API.Base;
using Trello.Test.API.Dtos.ReturnCep;
using Xunit;

namespace Trello.Test.API
{
    public class Tests : BaseTest
    {
        [Fact]
        public async Task GetCep()
        {
            var response = await Get<RetornoCeps>(Endpoints.BaseURI, Endpoints.Cep);
            Assert.NotNull(response);
        }
    }
}
