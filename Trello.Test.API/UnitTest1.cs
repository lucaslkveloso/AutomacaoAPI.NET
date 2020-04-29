using System.Threading.Tasks;
using Trello.Test.API.Base;
using Trello.Test.API.Dtos.ReturnCep;
using Xunit;

namespace Trello.Test.API
{
    public class UnitTest1 : BaseTest
    {
        [Fact]
        public async Task Test1Te()
        {
            var response = await Get<RetornoCeps>(Endpoints.BaseURI, Endpoints.Cep);
            Assert.NotNull(response);
        }
    }
}
