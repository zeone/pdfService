using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Dto
{
    public class FamilyDetails
    {
        public IList<ContactReportContactInfo> Contacts { get; set; }
        public IList<ContactReportAddress> Addresses { get; set; }
    }
}