using ConsoleApp24.Model.Factory.PhoneFactory;
using ConsoleApp24.Model.Interface.PhoneModel;
using ConsoleApp24.Model.PhoneModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<String> PhoneList = new List<String>();
            PhoneList.Add(new PhoneFactory().GetHTC().GetSimplePhone().GetName());
            PhoneList.Add(new PhoneFactory().GetNokia().GetSimplePhone().GetName());
            PhoneList.Add(new PhoneFactory().GetSamsungPhone().GetSimplePhone().GetName());
            PhoneList.Add(new PhoneFactory().GetHTC().GetSmartPhone().GetName());
            PhoneList.Add(new PhoneFactory().GetNokia().GetSmartPhone().GetName());
            PhoneList.Add(new PhoneFactory().GetSamsungPhone().GetSmartPhone().GetName());


            return View(PhoneList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
