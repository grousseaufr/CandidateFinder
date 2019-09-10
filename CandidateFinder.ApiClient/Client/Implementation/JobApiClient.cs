using CandidateFinder.ApiClient.Client;
using CandidateFinder.ApiClient.Dto;

namespace CandidateFinder.ApiClient.Client.Implementation
{
    public class JobApiClient : ApiClient<JobDto>
    {
        public JobApiClient()
        {
            requestUri = "jobs";
        }
    }
}
