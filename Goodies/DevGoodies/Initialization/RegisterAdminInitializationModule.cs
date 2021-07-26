namespace DevGoodies.Initialization
{
    using EPiServer.Core;
    using EPiServer.Security;
    using EPiServer.Framework;
    using EPiServer.DataAbstraction;
    using EPiServer.Framework.Initialization;

    using System.Web.Security;
    using System.Configuration;

    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class RegisterAdminInitializationModule : IInitializableModule
    {
        //--------------- CONSTANTS ---------------
        private const string Role = "WebAdmins";
        private const string Username = "Admin";
        private const string Password = "Pa$$w0rd";
        private const string Email = "admin@alloy.com";

        //---------------- METHODS ----------------
        public void Initialize(InitializationEngine context)
        {
            bool enabled;
            if (bool.TryParse(ConfigurationManager.AppSettings["alloy:RegisterAdmin"], out enabled))
            {
                if (enabled)
                {
                    #region Use ASP.NET Membership classes to create the role and user
                    // If the role does not exist, create it
                    if (!Roles.RoleExists(Role)) Roles.CreateRole(Role);

                    // If the user already exists, delete it
                    if (Membership.GetUser(Username) != null) Membership.DeleteUser(Username);
    
                    // Create the user with password and add it to role
                    Membership.CreateUser(Username, Password, Email);
                    Roles.AddUserToRole(Username, Role);
                    #endregion

                    #region Use EPiServer classes to give full access to Root of content tree
                    IContentSecurityRepository security = context.Locate.Advanced.GetInstance<IContentSecurityRepository>();

                    IContentSecurityDescriptor permissions = security.Get(ContentReference.RootPage).CreateWritableClone() as IContentSecurityDescriptor;
                    permissions.AddEntry(new AccessControlEntry(Role, AccessLevel.FullAccess));
                    security.Save(ContentReference.RootPage, permissions, SecuritySaveType.Replace);

                    permissions = security.Get(ContentReference.WasteBasket).CreateWritableClone() as IContentSecurityDescriptor;
                    permissions.AddEntry(new AccessControlEntry(Role, AccessLevel.FullAccess));
                    security.Save(ContentReference.WasteBasket, permissions, SecuritySaveType.Replace);
                    #endregion
                }
            }
        }

        public void Uninitialize(InitializationEngine context) { }
    }
}