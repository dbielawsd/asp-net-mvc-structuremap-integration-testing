using System.Configuration;
using AspNetMvcStructureMapIntegrationTesting.Retrievers.Interfaces;

namespace AspNetMvcStructureMapIntegrationTesting.Retrievers
{
    public class ConfigurationRetriever : IConfigurationRetriever
    {
        public string ConnectionString => ConfigurationManager.ConnectionStrings["db"].ConnectionString;
    }
}