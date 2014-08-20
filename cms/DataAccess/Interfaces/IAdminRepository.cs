namespace Cms.DataAccess.Interfaces
{
    using Cms.DomainObjects;

    public interface IAdminRepository
    {
        AdminUser GetAdminUser(string username, string password);
    }
}
