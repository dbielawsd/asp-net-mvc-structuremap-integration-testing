using AspNetMvcStructureMapIntegrationTesting.DependencyResolution;
using AspNetMvcStructureMapIntegrationTesting.IntegrationTests.Fakes;
using AspNetMvcStructureMapIntegrationTesting.Retrievers.Interfaces;
using StructureMap;

namespace AspNetMvcStructureMapIntegrationTesting.IntegrationTests.Test
{
    public class TestIocRegistry : Registry
    {
        public TestIocRegistry()
        {
            Scan(scanner =>
            {
                scanner.Assembly("AspNetMvcStructureMapIntegrationTesting");
                scanner.WithDefaultConventions();
                scanner.With(new ControllerConvention());
            });

            For<IConfigurationRetriever>().Use<FakeConfigurationRetriever>();
        }
    }
}
