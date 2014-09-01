using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DomainObjects
{
    using System.Runtime.Serialization;

    [DataContract]
    public class LoginResponse : BaseResponse
    {
        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public string Username { get; set; }
    }
}
