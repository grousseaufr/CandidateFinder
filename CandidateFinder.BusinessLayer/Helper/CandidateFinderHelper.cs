using CandidateFinder.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CandidateFinder.BusinessLayer.Helper
{
    public static class CandidateFinderHelper
    {
        public static List<Candidate> GetMatchingCandidates(List<Candidate> candidates, List<string> jobSkills, int maxCandidateCount)
        {
            var minMatchingSkills = 2;

            //Set a weight on each job skill
            var jobIndexedSkills = jobSkills.ToWeightedSkillList();

            foreach (var candidate in candidates)
            {
                //Set a weight on each candidate skill
                var candidateWeightedSkills = candidate.Skills.ToWeightedSkillList();

                //Get skill score for this candidate
                var skillResult = GetSkillScore(jobIndexedSkills, candidateWeightedSkills);
                candidate.Score = skillResult.Score;
                candidate.MatchingSkillsCount = skillResult.MatchCount;
            }

            return candidates.Where(w => w.MatchingSkillsCount >= minMatchingSkills).OrderByDescending(o => o.Score).Take(maxCandidateCount).ToList();
        }

        public static SkillResult GetSkillScore(List<WeightedSkill> jobSkills, List<WeightedSkill> candidateSkills)
        {
            SkillResult skillResult = new SkillResult();

            foreach (var jobSkill in jobSkills)
            {
                //Check if candidate has this skill
                var matchSkill = candidateSkills.FirstOrDefault(f => f.Name == jobSkill.Name);

                if (matchSkill != null)
                {
                    skillResult.Score += Math.Round(jobSkill.Weight * (matchSkill.Weight / 100), 2);
                    skillResult.MatchCount++;
                }
            }

            //TODO : possible evolution ? add bonus point regarding match count
            //if(skillResult.MatchCount > 0)
            //{
            //    skillResult.Score += (100 * skillResult.MatchCount);
            //}

            return skillResult;
        }


    }
}
