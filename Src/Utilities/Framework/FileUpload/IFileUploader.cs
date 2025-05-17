using Microsoft.AspNetCore.Http;

namespace Framework.FileUpload;

public interface IFileUploader
{
    string Upload(IFormFile file, string path);
}
