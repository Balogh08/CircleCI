using NetCoreCalculator.IntegrationTests.Fixtures;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NetCoreCalculator.IntegrationTests.Scenarios
{
    [Collection("BaseCollection")]
    public class HomeControllerTest
    {
        private readonly TestContext testContext;

        public HomeControllerTest(TestContext testContext)
        {
            this.testContext = testContext;
        }

        [Fact]
        public async Task HomeController_Get_Return200()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/index");
            var response = await testContext.Client.SendAsync(request);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
