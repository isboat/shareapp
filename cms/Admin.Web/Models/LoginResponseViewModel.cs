using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cms.Admin.Web.Models
{
    public class LoginResponseViewModel
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public string DisplayName { get; set; }

        public int UserId { get; set; }
    }
}