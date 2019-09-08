using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandidateFinder.ApiClient
{
    public interface IApiClient<T>
    {
        Task<List<T>> Get();
    }
}