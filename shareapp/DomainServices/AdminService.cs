using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices
{
    using DomainObjects;

    using DomainServices.Interfaces;

    public class AdminService : IAdminService
    {
        public LoginResponse AdminLogin(string username, string password)
        {
            var response = new LoginResponse();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                response.Success = true;
            }

            return response;
        }

        public CreateAdminAcctResponse CreateAdminAccount(CreateAdminAccRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
