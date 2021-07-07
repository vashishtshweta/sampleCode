using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication.Features.PrimeNumber
{
    public class PrimeNumberController : Controller
    {
        private readonly ILogger<PrimeNumberController> _logger;

        public PrimeNumberController(ILogger<PrimeNumberController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
