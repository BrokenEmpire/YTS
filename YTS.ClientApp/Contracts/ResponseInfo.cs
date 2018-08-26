using System.Collections.Generic;
using System.Runtime.Serialization;

namespace YTS.ClientApp.Contracts
{
    [DataContract(Name = "ResponseInfo")]
    public class ResponseInfo
    {
        [DataMember(Name = "movie_count")]
        public int Movie_Count { get; set; }

        [DataMember(Name = "limit")]
        public int Limit { get; set; }

        [DataMember(Name = "page_number")]
        public int Page_Number { get; set; }

        [DataMember(Name = "movies")]
        public List<MovieInfo> Movies { get; set; }
    }
}
