using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CandidateFinder.Models;
using CandidateFinder.ApiClient;

namespace CandidateFinder.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index(CandidateApiClient candidateApiClient, JobApiClient jobApiClient)
        {
            var candidates = await candidateApiClient.Get();
            var jobs = await jobApiClient.Get();
            return View();
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
