namespace Cms.ServiceProvider
{
    using Cms.Common;
    using Cms.DomainObjects;
    using Cms.DomainServices.Interfaces;
    using Cms.ServiceProvider.Interfaces;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    
    public class Service : IAdminServiceApi
    {
        #region Instances variables

        private readonly IAdminService adminService = Ioc.Resolve<IAdminService>();

        #endregion

        #region Admin

        public LoginResponse AdminLogin(string username, string password)
        {
            return adminService.AdminLogin(username, password);
        }

        public CreateAdminAcctResponse CreateAdminAccount(CreateAdminAccRequest request)
        {
            return new CreateAdminAcctResponse();
        }

        #endregion
    }
}
