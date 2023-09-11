using Microsoft.AspNetCore.Mvc;
using Services;
using ServicesContract;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICitiesService _citiesService;

        public HomeController()
        {
            //_citiesService = new CitiesService();
            _citiesService = null;
        }

        [Route("/")]
        public IActionResult Index()
        {
            List<string> cities = _citiesService.GetCities();
            return View(cities);
        }
    }
}
