namespace DevGoodies.Models.Media
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;
    using EPiServer.Framework.Blobs;
    using EPiServer.Framework.DataAnnotations;

    [ContentType(DisplayName = "SVG File", GUID = "daf8e0a4-4e64-4a70-b01f-b5b9fbe90b16", Description = "Upload a Scalable Vector Graphics (SVG) image.")]
    [MediaDescriptor(ExtensionString = "svg")]
    public class SVGFile : ImageData
    {
        // Instead of generating a smaller bitmap file for thumbnail, use the same binary vector image for thumbnail
        public override Blob Thumbnail { get => base.BinaryData; }
    }
}