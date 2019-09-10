using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandidateFinder.BusinessLayer;
using CandidateFinder.BusinessLayer.Services;
using CandidateFinder.UI.Models;
using CandidateFinder.UI.ModelsBuilder;
using Microsoft.AspNetCore.Mvc;

namespace CandidateFinder.UI.Controllers
{
    public class JobsController : Controller
    {
        private readonly JobViewModelBuilder jobViewModelBuilder;

        public JobsController(JobViewModelBuilder jobViewModelBuilder)
        {
            this.jobViewModelBuilder = jobViewModelBuilder;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = await jobViewModelBuilder.GetJobIndexViewModel();

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var viewModel = await jobViewModelBuilder.GetJobDetailsViewModel(id);

            return View(viewModel);
        }
    }
}