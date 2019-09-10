using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CandidateFinder.ApiClient.Client
{
    public abstract class ApiClient<T>
    {
        protected string requestUri;
        private HttpClient httpClient;
        private string baseAddress = "http://private-76432-jobadder1.apiary-mock.com/";

        public ApiClient()
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseAddress)
            };
        }

        public async Task<List<T>> Get()
        {
            using (var response = await httpClient.GetAsync(requestUri))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<T>>(responseData);
            }
        }
    }
}
