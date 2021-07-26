namespace DevGoodies.Business.Attributes
{
    using EPiServer.Shell.ObjectEditing;

    using DevGoodies.Business.SelectionFactories;

    using System;

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class OGTypeSelectionAttribute : SelectOneAttribute
    {
        // TODO: Now do it with SelectMany
        public string OGType { get; set; }

        public override Type SelectionFactoryType
        {
            get
            {
                return typeof(OGTypeSelectionFactory);
            }
            set
            {
                base.SelectionFactoryType = value;
            }
        }
    }
}