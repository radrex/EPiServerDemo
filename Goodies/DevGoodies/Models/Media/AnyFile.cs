namespace DevGoodies.Models.Media
{
    using EPiServer.Core;
    using EPiServer.DataAnnotations;

    [ContentType(DisplayName = "Any File", GUID = "c7e6590a-4667-4239-8587-a4821e51bbcc", Description = "Upload Any type of file.")]
    public class AnyFile : MediaData
    {

    }
}