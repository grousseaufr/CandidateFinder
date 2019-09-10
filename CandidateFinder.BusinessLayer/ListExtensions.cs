using CandidateFinder.BusinessLayer.Models;
using System;
using System.Collections.Generic;

namespace CandidateFinder.BusinessLayer
{
    public static class ListExtensions{

        /// <summary>
        /// Add a weight on each item of the list. First one is the heaviest with a value of 100.
        /// Example with 4 items: 100 75 50 25
        /// </summary>
        /// <param name="list">List of string</param>
        /// <returns>Weighted list of string</returns>
        public static List<WeightedSkill> ToWeightedSkillList(this List<string> list)
        {
            var index = list.Count;
            var weightedSkills = new List<WeightedSkill>(index);

            foreach (var item in list)
            {
                double percentage = Math.Round(GetPercentage(index, list.Count), 2);

                weightedSkills.Add(new WeightedSkill
                {
                    Name = item,
                    Weight = percentage
                });

                index--;
            }

            return weightedSkills;
        }

        private static double GetPercentage(int index, int total)
        {
            return (double)100 / (double)total * index;
        }
    }
}
