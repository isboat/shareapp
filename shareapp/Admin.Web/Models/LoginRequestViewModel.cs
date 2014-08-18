using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Web.Models
{
    public class LoginRequestViewModel
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}