namespace Cms.ServiceProvider.Interfaces
{
    using System.ServiceModel;

    using Cms.DomainObjects;

    [ServiceContract]
    public interface IAdminServiceApi
    {
        [OperationContract]
        LoginResponse AdminLogin(string username, string password);

        [OperationContract]
        CreateAdminAcctResponse CreateAdminAccount(CreateAdminAccRequest request);
    }
}
