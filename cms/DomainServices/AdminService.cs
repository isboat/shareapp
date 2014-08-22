using System;

namespace Cms.DomainServices
{
    using Cms.DataAccess.Interfaces;
    using Cms.DomainObjects;
    using Cms.DomainServices.Interfaces;

    public class AdminService : IAdminService
    {
        #region Instances variables

        private readonly IAdminRepository adminRepository;

        #endregion

        #region Ctor

        public AdminService(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        #endregion

        public LoginResponse AdminLogin(string username, string password)
        {
            var response = new LoginResponse();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var user = adminRepository.GetAdminUser(username, password);

                if (user != null)
                {
                    response.DisplayName = user.DisplayName;
                    response.UserId = user.UserId;
                    response.Success = true;
                }
                else
                {
                    response.Message = "No such user";
                }
            }

            return response;
        }
    }
}
