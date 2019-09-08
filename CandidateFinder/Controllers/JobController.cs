using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandidateFinder.BusinessLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace CandidateFinder.UI.Controllers
{
    public class JobsController : Controller
    {
        private readonly CandidateServices candidateServices;
        private readonly JobServices jobServices;

        public JobsController(CandidateServices candidateServices, JobServices jobServices)
        {
            this.candidateServices = candidateServices;
            this.jobServices = jobServices;
        }

        public async Task<IActionResult> Index()
        {
            var jobs = await jobServices.GetAll();
            return View(jobs);
        }
    }
}