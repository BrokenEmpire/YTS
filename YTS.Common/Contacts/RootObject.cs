using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace YTS.Common.Contacts
{
    [DataContract(Name = "RootObject")]
    public class RootObject
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "status_message")]
        public string Status_Message { get; set; }

        [DataMember(Name = "data")]
        public Data Data { get; set; }

        [DataMember(Name = "@meta")]
        public Meta Meta { get; set; }
    }
}
