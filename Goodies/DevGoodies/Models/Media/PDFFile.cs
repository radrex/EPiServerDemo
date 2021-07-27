namespace DevGoodies.Models.Media
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;
    using EPiServer.Framework.DataAnnotations;

    using System.ComponentModel.DataAnnotations;

    [ContentType(DisplayName = "PDF File", GUID = "735a2a95-8dbb-4ff0-9236-15688eb1abf5", Description = "Upload a Portable Document Format (PDF) file.")]
    [MediaDescriptor(ExtensionString = "pdf")]
    public class PDFFile : MediaData
    {
        [Display(Name = "Render preview image")] // false --> Render as simple hyperlink, true --> Render as clickable thumbnail preview image
        public virtual bool RenderPreviewImage { get; set; }
    }
}