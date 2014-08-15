using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceProvider
{
    using DomainObjects;

    using ServiceProvider.Interfaces;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    
    public class Service : IAdminService
    {
        public LoginResponse AdminLogin(LoginRequest request)
        {
            return new LoginResponse();
        }

        public CreateAdminAcctResponse CreateAdminAccount(CreateAdminAccRequest request)
        {
            return new CreateAdminAcctResponse();
        }
    }
}
