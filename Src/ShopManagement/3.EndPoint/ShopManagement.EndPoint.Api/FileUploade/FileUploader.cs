using Framework.FileUpload;
using Framework.Tools;

namespace ShopManagement.EndPoint.Api.FileUploade;

public class FileUploader(IWebHostEnvironment webHostEnvironment) : IFileUploader
{
    public string Upload(IFormFile file, string path)
    {
        if (file == null) return "";

        var directoryPath = $"{webHostEnvironment.WebRootPath}{path}";
        if (!Directory.Exists(directoryPath))
            Directory.CreateDirectory(directoryPath);

        var fileName = $"{DateTime.Now.ToFileName()}-{file.FileName}";
        var filePath = $"{directoryPath}//{fileName}";
        using var output = File.Create(filePath);
        file.CopyTo(output);
        return $"{path}/{fileName}";
    }
}
