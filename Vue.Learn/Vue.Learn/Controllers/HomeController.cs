using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Vue.Learn.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
