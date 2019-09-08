using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CandidateFinder.ApiClient
{
    public class JobApiClient : ApiClient<Job>
    {
        public JobApiClient()
        {
            requestUri = "jobs";
        }
    }
}
