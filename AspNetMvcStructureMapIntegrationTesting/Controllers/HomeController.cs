using System.Web.Mvc;
using AspNetMvcStructureMapIntegrationTesting.Retrievers.Interfaces;

namespace AspNetMvcStructureMapIntegrationTesting.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataRetriever _dataRetriever;

        public HomeController(IDataRetriever dataRetriever)
        {
            _dataRetriever = dataRetriever;
        }

        public ActionResult Index()
        {
            var data = _dataRetriever.Retrieve();
            return View((object) data);
        }
    }
}