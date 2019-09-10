using NUnit.Framework;
using System.Collections.Generic;
using CandidateFinder.BusinessLayer;

namespace Tests
{
    [TestFixture]
    public class CandidateFinderHelperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NoMatchingSkillReturnScore0()
        {
            var jobSkill = new List<string>
            {
                "skill-job-1",
                "skill-job-2"
            };

            var candidateSkill = new List<string>
            {
                "skill-1",
                "skill-2"
            };

            var skillResult = CandidateFinderHelper.GetSkillScore(jobSkill.ToWeightedSkillList(), candidateSkill.ToWeightedSkillList());

            Assert.AreEqual(skillResult.Score, 0);
        }

        [Test]
        public void OneMatchingSkillReturnScoreGreaterThan0()
        {
            var jobSkill = new List<string>
            {
                "skill-job-1"
            };

            var candidateSkill = new List<string>
            {
                "skill-job-1"
            };

            var skillResult = CandidateFinderHelper.GetSkillScore(jobSkill.ToWeightedSkillList(), candidateSkill.ToWeightedSkillList());

            Assert.Greater(skillResult.Score, 0);
        }

        [Test]
        public void OneMatchingSkillReturnMatchingCountEqualOne()
        {
            var jobSkill = new List<string>
            {
                "skill-job-1"
            };

            var candidateSkill = new List<string>
            {
                "skill-job-1"
            };

            var skillResult = CandidateFinderHelper.GetSkillScore(jobSkill.ToWeightedSkillList(), candidateSkill.ToWeightedSkillList());

            Assert.AreEqual(skillResult.MatchCount, 1);
        }

        [Test]
        public void TwoMatchingSkillReturnMatchingCountEqualTwo()
        {
            var jobSkill = new List<string>
            {
                "skill-job-1",
                "skill-job-2",
                "skill-job-3"
            };

            var candidateSkill = new List<string>
            {
                "skill-job-1",
                "skill-job-2",
                "skill-job-4"
            };

            var skillResult = CandidateFinderHelper.GetSkillScore(jobSkill.ToWeightedSkillList(), candidateSkill.ToWeightedSkillList());

            Assert.AreEqual(skillResult.MatchCount, 2);
        }

        [Test]
        public void DuplicateSkillShouldBeTakenOnlyOnce()
        {
            var jobSkill = new List<string>
            {
                "skill-job-1"
            };

            var candidateSkill = new List<string>
            {
                "skill-job-1",
                "skill-job-1"
            };

            var skillResult = CandidateFinderHelper.GetSkillScore(jobSkill.ToWeightedSkillList(), candidateSkill.ToWeightedSkillList());

            Assert.AreEqual(skillResult.MatchCount, 1);
        }
    }
}