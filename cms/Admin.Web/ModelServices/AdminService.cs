namespace Cms.Admin.Web.ModelServices
{
    using Cms.Admin.Web.Models;

    public class AdminService
    {
        public LoginResponseViewModel Login(LoginRequestViewModel request)
        {
            return new LoginResponseViewModel { Success = true};
        }
    }
}