using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Dto
{
    public class GroupedContactReport
    {
        public string Name { get; set; }
        public List<ContactReportResultDto> Contacts { get; set; }
    }
}