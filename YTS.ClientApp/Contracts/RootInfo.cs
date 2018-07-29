using System.Runtime.Serialization;

namespace YTS.ClientApp.Contracts
{
    public class RootInfo
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "status_message")]
        public string Status_Message { get; set; }

        [DataMember(Name = "data")]
        public ResponseInfo Data { get; set; }

        [DataMember(Name = "@meta")]
        public MetaInfo Meta { get; set; }
    }
}
