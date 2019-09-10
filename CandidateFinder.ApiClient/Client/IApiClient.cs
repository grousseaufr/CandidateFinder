using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandidateFinder.ApiClient.Client
{
    public interface IApiClient<T>
    {
        Task<List<T>> Get();
    }
}