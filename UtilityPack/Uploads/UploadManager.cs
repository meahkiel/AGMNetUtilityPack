using Microsoft.AspNetCore.Http;

namespace UtilityPack.Uploads
{
    public class UploadManager
    {
        private readonly FileOption _fileOption;

        public UploadManager(FileOption fileOption)
        {
            _fileOption = fileOption;
        }

        public async Task<FileDownloadResult> DownloadFile(string fileName)
        {
            //download file
            var result = new FileDownloadResult();
            var path = Path.Combine(Directory.GetCurrentDirectory(), _fileOption.Path, fileName);
            string contentType = "application/octet-stream";

            result.DocumentFile = await File.ReadAllBytesAsync(path);
            result.ContentType = contentType;

            return result;

        }

        public async Task<FileResult> Upload(IFormFile file, string newFileName)
        {

            var formFile = file;
            var fileName = file.FileName;
            var fileExtension = Path.GetExtension(fileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), _fileOption.Path, newFileName);
            await CopyStream(formFile, filePath);

            return new FileResult
            {
                FilePath = filePath,
                FileName = newFileName,
                Type = fileExtension,
            };
        }

        private async Task CopyStream(IFormFile file, string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                await file.CopyToAsync(fileStream);
            }
        }
    }
}
