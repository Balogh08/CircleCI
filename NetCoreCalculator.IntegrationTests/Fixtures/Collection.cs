using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NetCoreCalculator.IntegrationTests.Fixtures
{
    [CollectionDefinition("BaseCollection")]
    public class Collection : ICollectionFixture<TestContext>
    {
    }
}
