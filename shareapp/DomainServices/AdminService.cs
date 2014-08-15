﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices
{
    using DataAccess.Interfaces;
    using DomainObjects;
    using DomainServices.Interfaces;

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

        public CreateAdminAcctResponse CreateAdminAccount(CreateAdminAccRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
