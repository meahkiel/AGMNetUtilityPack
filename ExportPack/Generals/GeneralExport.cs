using ExportPack.Base;
using ExportPack.Commons;
using ExportPack.Contracts;
using System.Data;

namespace ExportPack.Generals
{
    public sealed class GeneralExport : ExcelReadBase<string>, IGeneralExport
    {
        public async Task<ExportResult> GetExcelReport(DataSet dataset, string fileName) {
            var rawData = await ExportExcel(dataset.Tables[0], false);
            return new ExportResult(rawData, $"{fileName}.xlsx", DateTime.Now, ExcelContentType);
        }

        protected override DataTable ListToDataTable(List<string> results)
        {
            throw new NotImplementedException();
        }
    }
}
