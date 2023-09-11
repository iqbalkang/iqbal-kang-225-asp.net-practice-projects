using Microsoft.AspNetCore.Mvc;
using Services;
using ServicesContract;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICitiesService _citiesService1;
        private readonly ICitiesService _citiesService2;
        private readonly ICitiesService _citiesService3;

        public HomeController(ICitiesService citiesService1, ICitiesService citiesService2, ICitiesService citiesService3)
        {
            _citiesService1 = citiesService1;
            _citiesService2 = citiesService2;
            _citiesService3 = citiesService3;
        }

        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.instanceID1 = _citiesService1.InstanceID;
            ViewBag.instanceID2 = _citiesService2.InstanceID;
            ViewBag.instanceID3 = _citiesService3.InstanceID;
            List<string> cities = _citiesService1.GetCities();
            return View(cities);
        }
    }
}
