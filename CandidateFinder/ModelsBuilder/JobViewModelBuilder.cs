using CandidateFinder.BusinessLayer.Helper;
using CandidateFinder.BusinessLayer.Services;
using CandidateFinder.UI.Models;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateFinder.UI.ModelsBuilder
{
    public class JobViewModelBuilder
    {
        private readonly CandidateServices candidateServices;
        private readonly JobServices jobServices;

        private const short MAX_CANDIDATE_COUNT = 20;

        public JobViewModelBuilder(CandidateServices candidateServices, JobServices jobServices)
        {
            this.candidateServices = candidateServices;
            this.jobServices = jobServices;
        }

        public async Task<JobIndexViewModel> GetJobIndexViewModel()
        {
            var jobIndexViewModel = new JobIndexViewModel();
            jobIndexViewModel.Jobs = await jobServices.GetAll();

            return jobIndexViewModel;
        }

        public async Task<JobDetailsViewModel> GetJobDetailsViewModel(int id)
        {
            var job = await jobServices.GetById(id);
            var candidates = await candidateServices.GetAll();
            var scoredCandidates = CandidateFinderHelper.GetMatchingCandidates(candidates, job.Skills, MAX_CANDIDATE_COUNT);

            var viewModel = new JobDetailsViewModel
            {
                Job = job,
                Candidates = scoredCandidates.ToList()
            };

            return viewModel;
        }
    }
}
