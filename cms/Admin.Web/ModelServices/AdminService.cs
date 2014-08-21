using Cms.Admin.Web.Models;

namespace Cms.Admin.Web.ModelServices
{
    public class AdminService
    {
        /// <summary>
        /// The login.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="LoginResponseViewModel"/>.
        /// </returns>
        public LoginResponseViewModel Login(LoginRequestViewModel request)
        {
            return new LoginResponseViewModel { Success = true};
        }
    }
}