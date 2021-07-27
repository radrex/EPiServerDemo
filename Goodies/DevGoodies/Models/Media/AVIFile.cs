namespace DevGoodies.Models.Media
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;
    using EPiServer.Framework.DataAnnotations;

    [ContentType(DisplayName = "AVI File", GUID = "03c74731-a98a-4326-86f9-14482cc8ec68", Description = "Upload an Audio Video Interleave (AVI) file.")]
    [MediaDescriptor(ExtensionString = "avi")]
    public class AVIFile : VideoData
    {

    }
}