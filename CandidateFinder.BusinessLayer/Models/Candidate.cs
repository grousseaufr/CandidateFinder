using System.Collections.Generic;

namespace CandidateFinder.BusinessLayer.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Skills { get; set; }
        public double Score { get; set; }
        public int MatchingSkillsCount { get; set; }
    }
}
