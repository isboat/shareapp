using DataAccess.Interfaces;
using DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public AdminUser GetAdminUser(string username, string password)
        {
            if (username == "aaa")
            {
                return new AdminUser();
            }
            return null;
        }
    }
}
