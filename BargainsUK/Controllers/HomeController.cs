using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BargainsUK.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BargainsUK.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICurrencyRepository _currencyRepo;

        public HomeController(ICurrencyRepository currencyRepository)
        {
            _currencyRepo = currencyRepository;
        }

        public ActionResult Index()
        {
            //
            // TEST
            var currencies = _currencyRepo.GetAll();
            //

            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
