using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DomainObjects
{
    using System.Runtime.Serialization;

    [DataContract]
    public class LoginResponse
    {
        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public int UserId { get; set; }
    }
}
