using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Dto
{
    public class PdfDocumentDto
    {
        public ReportDto ReportDto { get; set; }
        public List<ContactReportResultDto> Contacts { get; set; }
        public FilterTransactionReport Filter { get; set; }
        public TransactionGrouped Grouped { get; set; }
        public int CountTrans { get; set; }
    }

}