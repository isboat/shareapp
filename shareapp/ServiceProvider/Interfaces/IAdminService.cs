using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProvider.Interfaces
{
    using System.ServiceModel;

    using DomainObjects;

    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        LoginResponse AdminLogin(LoginRequest request);

        [OperationContract]
        CreateAdminAcctResponse CreateAdminAccount(CreateAdminAccRequest request);
    }
}
