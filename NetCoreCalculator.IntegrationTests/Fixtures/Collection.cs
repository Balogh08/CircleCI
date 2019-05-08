using Xunit;

namespace NetCoreCalculator.IntegrationTests.Fixtures
{
    [CollectionDefinition("BaseCollection")]
    public class Collection : ICollectionFixture<TestContext>
    {
    }
}
