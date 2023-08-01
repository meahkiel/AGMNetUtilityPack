namespace UtilityPack.Uploads;

public class FileResult {
    public string FilePath { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string FullFileName => $"{FileName}.{Type}";
}
