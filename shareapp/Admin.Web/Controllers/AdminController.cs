using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Admin.Web.Controllers
{
    using Admin.Web.ModelServices;
    using Admin.Web.Models;

    public class AdminController : ApiController
    {
        private readonly AdminService adminService = new AdminService();

        [HttpPost]
        public LoginResponseViewModel Login(LoginRequestViewModel request)
        {
            return adminService.Login(request);
        }
    }
}