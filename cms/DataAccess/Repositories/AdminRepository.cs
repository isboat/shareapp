namespace Cms.DataAccess.Repositories
{
    using Cms.DataAccess.Interfaces;
    using Cms.DomainObjects;

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
