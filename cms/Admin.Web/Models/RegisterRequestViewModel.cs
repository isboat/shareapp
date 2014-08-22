using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cms.Admin.Web.Models
{
    public class RegisterRequestViewModel
    {
        public string OrgName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}