using ExportPack.Contracts;
using ExportPack.Generals;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;

namespace ExportPack
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddReportService(this IServiceCollection services)
        {   
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            services.AddScoped<IGeneralExport, GeneralExport>();
            services.AddScoped<IExportObjectManager, ExportObjectManager>();

            return services;
        }
    }
}
