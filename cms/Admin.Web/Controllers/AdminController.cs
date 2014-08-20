using System.Web.Http;

namespace Cmss.Admin.Web.Controllers
{
    using Cms.Admin.Web.ModelServices;
    using Cms.Admin.Web.Models;

    public class AdminController : ApiController
    {
        private readonly AdminService adminService = new AdminService();

        [HttpPost]
        public LoginResponseViewModel Login(LoginRequestViewModel request)
        {
            return this.adminService.Login(request);
        }

        [HttpPost]
        public RegisterResponseViewModel Register(RegisterRequestViewModel request)
        {
            return new RegisterResponseViewModel();
        }
    }
}