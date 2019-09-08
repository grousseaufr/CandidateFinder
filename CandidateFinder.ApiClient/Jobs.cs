using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CandidateFinder.ApiClient
{
    [DataContract]
    public class Job
    {
        [DataMember(Name = "jobId")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "company")]
        public string Company { get; set; }

        [DataMember(Name = "skills")]
        public string Skills { get; set; }
    }
}