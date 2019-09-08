using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CandidateFinder.ApiClient
{
    [DataContract]
    public class Candidate
    {
        [DataMember(Name = "candidateId")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "skillTags")]
        public string Skills { get; set; }
    }
}