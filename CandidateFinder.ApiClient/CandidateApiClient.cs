using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CandidateFinder.ApiClient
{
    public class CandidateApiClient : ApiClient<Candidate>
    {
        public CandidateApiClient()
        {
            requestUri = "candidates";
        }
    }
}
