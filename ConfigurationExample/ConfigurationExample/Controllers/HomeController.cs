using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly WeatherAPIOptions _options;
        public HomeController(IOptions<WeatherAPIOptions> configOptions)
        {
            _options = configOptions.Value;
        }

        [Route("/")]
        public IActionResult Index()
        {
         
            ViewBag.clientID = _options.ClientID;
            ViewBag.clientPassword = _options.ClientPassword;

            return View();
        }
    }
}




//using Microsoft.AspNetCore.Mvc;

//namespace ConfigurationExample.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly IConfiguration _configuration;
//        public HomeController(IConfiguration configuration)
//        {
//            _configuration = configuration;
//        }

//        [Route("/")]
//        public IActionResult Index()
//        {
//            //ViewBag.key1 = _configuration.GetValue<int>("Key1");
//            //ViewBag.defaultKey = _configuration.GetValue<string>("DefaultKey", "This is the default value.");

//            //IConfigurationSection configSection = _configuration.GetSection("weatherAPI");

//            //WeatherAPIOptions configSection = _configuration.GetSection("weatherAPI").Get<WeatherAPIOptions>();

//            WeatherAPIOptions configSection = new WeatherAPIOptions();

//            _configuration.GetSection("weatherAPI").Bind(configSection);


//            ViewBag.clientID = configSection.ClientID;
//            ViewBag.clientPassword = configSection.ClientPassword;

//            return View();
//        }
//    }
//}
