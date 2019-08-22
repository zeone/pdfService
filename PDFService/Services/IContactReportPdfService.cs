using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDFService.Dto;

namespace PDFService.Services
{
    public interface IContactReportPdfService
    {
        byte[] CreateDocument(ReportDto reportDto, List<ContactReportResultDto> contacts, string countryName,
            Func<string, string> transFunc);
    }
}
