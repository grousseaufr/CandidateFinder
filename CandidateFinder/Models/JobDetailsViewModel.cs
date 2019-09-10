using CandidateFinder.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateFinder.UI.Models
{
    public class JobDetailsViewModel
    {
        public Job Job { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
