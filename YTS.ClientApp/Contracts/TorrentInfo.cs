using System.Runtime.Serialization;

namespace YTS.ClientApp.Contracts
{
    [DataContract(Name = "Torrent")]
    public class TorrentInfo
    {
        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "hash")]
        public string Hash { get; set; }

        [DataMember(Name = "quality")]
        public string Quality { get; set; }

        [DataMember(Name = "seeds")]
        public int Seeds { get; set; }

        [DataMember(Name = "peers")]
        public int Peers { get; set; }

        [DataMember(Name = "size")]
        public string Size { get; set; }

        [DataMember(Name = "size_bytes")]
        public int Size_bytes { get; set; }

        [DataMember(Name = "date_uploaded")]
        public string Date_uploaded { get; set; }

        [DataMember(Name = "date_uploaded_unix")]
        public int Date_uploaded_unix { get; set; }
    }
}
