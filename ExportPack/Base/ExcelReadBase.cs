using OfficeOpenXml;
using System.Data;

namespace ExportPack.Base;

public abstract class ExcelReadBase<T> where T : class
{
    public static string ExcelContentType => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
    protected abstract DataTable ListToDataTable(List<T> results);

    public async Task<byte[]> ExportExcel(List<T> data) {
        return await ExportExcel(ListToDataTable(data), false);
    }

    public async Task<byte[]?> ExportExcelDataset(DataTable dataTable, bool showHeader = false) {
        return await ExportExcel(dataTable, showHeader);
    }

    protected virtual async Task<byte[]> ExportExcel(
       DataTable dataTable,
       bool heading,
       string headerName = "Import")
    {

        byte[] result = null;
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        using (ExcelPackage package = new ExcelPackage())
        {
            ExcelWorksheet workSheet = package.Workbook.Worksheets.Add(String.Format("Data", heading));
            int startRowFrom = heading ? 2 : 1;

            var totalRow = dataTable.Rows.Count;
            workSheet.Cells["A" + startRowFrom].LoadFromDataTable(dataTable, true);

            result = await package.GetAsByteArrayAsync();

            return result;
        }
    }
}
