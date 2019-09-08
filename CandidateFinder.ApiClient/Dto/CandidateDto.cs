using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CandidateFinder.ApiClient.Dto
{
    [DataContract]
    public class CandidateDto
    {
        [DataMember(Name = "candidateId")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "skillTags")]
        public string Skills { get; set; }
    }
}