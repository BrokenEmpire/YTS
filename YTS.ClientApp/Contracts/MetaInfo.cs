using System.Runtime.Serialization;

namespace YTS.ClientApp.Contracts
{
    [DataContract(Name = "Meta")]
    public class MetaInfo
    {
        [DataMember(Name = "server_time")]
        public int Server_Time { get; set; }

        [DataMember(Name = "server_timezone")]
        public string Server_Timezone { get; set; }

        [DataMember(Name = "api_version")]
        public int API_Version { get; set; }

        [DataMember(Name = "execution_time")]
        public string Execution_Time { get; set; }
    }
}
