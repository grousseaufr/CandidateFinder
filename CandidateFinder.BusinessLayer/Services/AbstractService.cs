using CandidateFinder.ApiClient.Client;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateFinder.BusinessLayer.Services
{
    public abstract class AbstractService<T, Tdto> where T:class where Tdto : class
    {
        private readonly IApiClient<Tdto> apiClient;
        private List<T> items;

        public AbstractService(IApiClient<Tdto> apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<List<T>> GetAll()
        {
            if (items == null)
            {
                var dtos = await apiClient.Get();
                items = dtos.Select(Adapt).ToList();
            }

            return items;
        }
            
        protected abstract T Adapt(Tdto dto);
    }
}
