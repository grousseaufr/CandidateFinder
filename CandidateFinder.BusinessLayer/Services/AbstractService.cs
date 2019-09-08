using CandidateFinder.ApiClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateFinder.BusinessLayer.Services
{
    public abstract class AbstractService<T, Tdto> where Tdto : class
    {
        private readonly IApiClient<Tdto> apiClient;

        public AbstractService(IApiClient<Tdto> apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<List<T>> GetAll()
        {
            var dtos = await apiClient.Get();
            return dtos.Select(Adapt).ToList();
        }

        protected abstract T Adapt(Tdto dto);
    }
}
