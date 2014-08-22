using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cms.Admin.Web.Models
{
    public class LoginResponseViewModel : BaseResponseViewModel
    {
        public string DisplayName { get; set; }

        public int UserId { get; set; }
    }
}