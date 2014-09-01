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

            return new LoginResponseViewModel 
            { 
                Success = response.Success, 
                Message = response.Message, 
                CmsId = "abcd1234", 
                Username = response.Username};
        }

        public RegisterResponseViewModel Register(RegisterRequestViewModel request)
        {
            var response = this.adminServiceApi.CreateAdminAccount(
                request.OrgName, request.Username, request.Email, request.Password);

            var result = new RegisterResponseViewModel();
            
            if (response != null)
            {
                result.Success = response.Success;
                result.Message = response.Message;
            }

            return result;
        }
    }
}