using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace NetCoreCalculator.IntegrationTests.Fixtures
{
    public class TestContext
    {
        private TestServer server;
        public HttpClient Client { get; set; }

        public TestContext()
        {
            var builder = new WebHostBuilder()
                .UseEnvironment("Testing")
                .UseStartup<Startup>();

            server = new TestServer(builder);
            Client = server.CreateClient();
            Client.BaseAddress = new Uri("http://localhost:53497/");
        }

        public void Dispose()
        {
            server.Dispose();
            Client.Dispose();
        }
    }
}
