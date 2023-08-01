namespace UtilityPack.Uploads;

public class FileDownloadResult
{
    public string FileName { get; set; } = string.Empty;
    public byte[] DocumentFile { get; set; } = Array.Empty<byte>();
    public string ContentType { get; set; } = string.Empty;
    public int Size => DocumentFile.Length;
}
