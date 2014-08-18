using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Web.ModelServices
{
    using Admin.Web.Models;

    public class AdminService
    {
        public LoginResponseViewModel Login(LoginRequestViewModel request)
        {
            return new LoginResponseViewModel { Success = true};
        }
    }
}