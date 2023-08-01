using ExportPack.Commons;
using System.Data;

namespace ExportPack.Contracts
{
    public interface IGeneralExport
    {
        Task<ExportResult> GetExcelReport(DataSet dataset, string fileName);
    }
}
