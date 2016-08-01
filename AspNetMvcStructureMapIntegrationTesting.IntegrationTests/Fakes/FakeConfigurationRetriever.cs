using AspNetMvcStructureMapIntegrationTesting.Retrievers.Interfaces;

namespace AspNetMvcStructureMapIntegrationTesting.IntegrationTests.Fakes
{
    public class FakeConfigurationRetriever : IConfigurationRetriever
    {
        public string ConnectionString => @"Data Source=.\SQLEXPRESS;Initial Catalog=integration_testing;Persist Security Info=True;User ID=sa;password=test;Pooling=false";
    }
}