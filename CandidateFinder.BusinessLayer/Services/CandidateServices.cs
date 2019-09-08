using CandidateFinder.ApiClient;
using CandidateFinder.ApiClient.Dto;
using CandidateFinder.BusinessLayer.Models;
using System.Linq;
using System.Text.RegularExpressions;

namespace CandidateFinder.BusinessLayer.Services
{
    public class CandidateServices : AbstractService<Candidate, CandidateDto>
    {
        public CandidateServices(CandidateApiClient candidateApiClient) : base(candidateApiClient)
        {
        }

        protected override Candidate Adapt(CandidateDto dto)
        {
            if (dto != null)
            {
                return new Candidate
                {
                    Id = dto.Id,
                    Name = dto.Name,
                    Skills = !string.IsNullOrEmpty(dto.Skills) ? Regex.Replace(dto.Skills, @"\s+", "").Split(',').ToList() : null
                };
            }

            return null;
        }

        
    }
}
