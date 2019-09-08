using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CandidateFinder.Models;
using CandidateFinder.ApiClient;
using CandidateFinder.BusinessLayer.Services;

namespace CandidateFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly CandidateServices candidateServices;
        private readonly JobServices jobServices;

        public HomeController(CandidateServices candidateServices, JobServices jobServices)
        {
            this.candidateServices = candidateServices;
            this.jobServices = jobServices;
        }

        public async Task<IActionResult> Index()
        {
            var candidates = await candidateServices.GetAll();
            var jobs = await jobServices.GetAll();
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
