using Cms.Admin.Web.Models;

namespace Cms.Admin.Web.ModelServices
{
    using Cms.Admin.Web.ServiceProvider;

    public class AdminService
    {
        #region instance variables

        /// <summary>
        /// The admin service api.
        /// </summary>
        private readonly AdminServiceApiClient adminServiceApi = new AdminServiceApiClient();

        #endregion
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
            var response = this.adminServiceApi.AdminLogin(request.Username, request.Password);

            return new LoginResponseViewModel { Success = response.Success };
        }
    }
}