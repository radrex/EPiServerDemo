namespace DevGoodies.Business.Constants
{
    using EPiServer.Security;
    using EPiServer.DataAnnotations;

    using System.ComponentModel.DataAnnotations;

    [GroupDefinitions]
    public static class Tabs
    {
        [Display(Order = 10)]
        [RequiredAccess(AccessLevel.Edit)]
        public const string SEO = "SEO";

        [Display(Order = 20)]
        [RequiredAccess(AccessLevel.Edit)]
        public const string Events = "Events";

        [Display(Order = 30)]
        [RequiredAccess(AccessLevel.Administer)]
        public const string SiteSettings = "Site Settings";
    }
}