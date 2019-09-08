using CandidateFinder.ApiClient.Dto;

namespace CandidateFinder.ApiClient
{
    public class CandidateApiClient : ApiClient<CandidateDto>
    {
        public CandidateApiClient()
        {
            requestUri = "candidates";
        }
    }
}
