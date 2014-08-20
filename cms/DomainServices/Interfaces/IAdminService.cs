namespace Cms.DomainServices.Interfaces
{
    using Cms.DomainObjects;

    public interface IAdminService
    {
        LoginResponse AdminLogin(string username, string password);

        CreateAdminAcctResponse CreateAdminAccount(CreateAdminAccRequest request);
    }
}
