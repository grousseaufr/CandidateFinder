using CandidateFinder.ApiClient;
using CandidateFinder.ApiClient.Dto;
using CandidateFinder.BusinessLayer.Models;
using System.Linq;
using System.Text.RegularExpressions;

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

        
    }
}
