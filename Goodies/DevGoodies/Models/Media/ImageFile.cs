namespace DevGoodies.Models.Media
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;
    using EPiServer.Framework.DataAnnotations;

    using System.ComponentModel.DataAnnotations;

    [ContentType(DisplayName = "Image File", GUID = "4448ed6d-aeb9-49c5-b039-23a910367e2f", Description = "Upload an Image file.")]
    [MediaDescriptor(ExtensionString = "png,gif,jpg,jpeg")]
    public class ImageFile : ImageData
    {
        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }

        [CultureSpecific]
        [Editable(true)]
        public virtual string Alt { get; set; }
    }
}