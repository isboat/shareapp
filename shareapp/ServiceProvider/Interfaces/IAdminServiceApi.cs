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
    public interface IAdminServiceApi
    {
        [OperationContract]
        LoginResponse AdminLogin(string username, string password);

        [OperationContract]
        CreateAdminAcctResponse CreateAdminAccount(CreateAdminAccRequest request);
    }
}
