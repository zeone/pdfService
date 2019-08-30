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
        byte[] CreateDocument(object docObj);
    }
}
