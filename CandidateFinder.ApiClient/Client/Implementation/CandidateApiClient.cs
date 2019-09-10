using CandidateFinder.ApiClient.Client;
using CandidateFinder.ApiClient.Dto;

namespace CandidateFinder.ApiClient.Client.Implementation
{
    public class CandidateApiClient : ApiClient<CandidateDto>
    {
        public CandidateApiClient()
        {
            requestUri = "candidates";
        }
    }
}
