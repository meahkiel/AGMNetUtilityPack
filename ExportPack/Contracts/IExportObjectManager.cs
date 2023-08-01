using ExportPack.Commons;
using System.Data;

namespace ExportPack.Contracts
{
    public interface IExportObjectManager
    {
        Task<ExportResult> GenerateExcel<T>(List<T> results, string fileName);
        Task<ExportResult> GenerateExcelWithDSet(DataSet ds, string fileName);

        Task<ExportResult?> GenerateExcelDynamic(List<dynamic> results, string fileName);
    }
}
