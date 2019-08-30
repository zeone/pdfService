using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PDFService.Dto
{
    [DataContract]
    public class ContactReportPdfOnlyRequest : BaseFilterRequest
    {

        /// <summary>
        /// list of prepared contact info
        /// </summary>
        [DataMember]
        public List<ContactReportResultDto> Contacts { get; set; }

    }
}