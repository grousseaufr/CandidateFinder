using CandidateFinder.ApiClient.Dto;

namespace CandidateFinder.ApiClient
{
    public class JobApiClient : ApiClient<JobDto>
    {
        public JobApiClient()
        {
            requestUri = "jobs";
        }
    }
}
