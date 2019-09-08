using System.Collections.Generic;

namespace CandidateFinder.BusinessLayer.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public List<string> Skills { get; set; }
    }
}
