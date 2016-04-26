using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using HomeSensors.Presentation.Contracts;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeSensors.Presentation.Controllers
{
    public class HomeController : Controller
    {
        ISensorsService _sensorService;
        public HomeController(ISensorsService sensorService)
        {

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
