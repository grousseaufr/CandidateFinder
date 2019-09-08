using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CandidateFinder.ApiClient
{
    public class ApiClient<T>
    {
        private HttpClient httpClient;
        protected string requestUri;
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
