﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DomainObjects
{
    using System.Runtime.Serialization;

    [DataContract]
    public class CreateAdminAcctResponse : BaseResponse
    {
        public string OrgId { get; set; }
    }
}
