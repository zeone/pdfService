using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDFService.Dto;

namespace PDFService.Services
{
    public interface IReportService
    {
        byte[] GetPdf(FilterTransactionReport filter, Func<string, string> translateFunc);
        byte[] GetPdf(ReportDto reportDto, Func<string, string> translateFunc, string country = null);
    }
}
