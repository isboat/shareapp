using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Interfaces
{
    using DomainObjects;

    public interface IAdminService
    {
        LoginResponse AdminLogin(string username, string password);

        CreateAdminAcctResponse CreateAdminAccount(CreateAdminAccRequest request);
    }
}
