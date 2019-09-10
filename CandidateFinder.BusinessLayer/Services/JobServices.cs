using CandidateFinder.ApiClient.Client.Implementation;
using CandidateFinder.ApiClient.Dto;
using CandidateFinder.BusinessLayer.Models;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CandidateFinder.BusinessLayer.Services
{
    public class JobServices : AbstractService<Job, JobDto>
    {
        public JobServices(JobApiClient jobApiClient) : base(jobApiClient)
        {
        }

        protected override Job Adapt(JobDto dto)
        {
            if (dto != null)
            {
                return new Job
                {
                    Id = dto.Id,
                    Name = dto.Name,
                    Company = dto.Company,
                    Skills = !string.IsNullOrEmpty(dto.Skills) ? Regex.Replace(dto.Skills, @"\s+", "").Split(',').ToList() : null
                };
            }

            return null;
        }

        public async Task<Job> GetById(int id)
        {
            var jobs = await GetAll();
            return jobs.FirstOrDefault(s => s.Id == id);
        }
    }
}
